using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingForm.Controllers
{
    public class ConfirmationsController : Controller
    {
        private readonly BookingFormContext _context;
        public ConfirmationsController(BookingFormContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var invoices = await _context.Invoice.Include(e => e.Client).Include(e => e.Apartment)
                            .Include(e => e.Confirmation).ToListAsync();
                var item = invoices.FirstOrDefault(e => e.Client.Id == id);
                return View("Success", item);

            }
            catch (System.NullReferenceException e)
            {
                return View("Error", $"Mã hóa đơn không tồn tại, vui lòng kiểm tra lại. [Error code {e.Message}]");
            }

        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var confirmations = await _context.Confirmation.Where(e => true).ToListAsync();
                var confirmView = new List<ConfirmationList>();
                foreach (var item in confirmations)
                {
                    var apartment = await GetApartment(item.LocalCode);
                    var client = await GetClient(item.ClientId);
                    var reserved = await GetReservation(item.RCC);
                    confirmView.Add(new ConfirmationList
                    {
                        ApartmentCode = apartment.LocalCode,
                        Client = client.FullName,
                        NOReserved = ReadNumberOfReserved(apartment.LocalCode),
                        IsReserved = true
                    });
                }
                return View(confirmView);

            }
            catch (System.NullReferenceException e)
            {
                return View("Error", $"Hệ thống xảy ra lỗi [error code {e.Message}]");
            }
        }

        private int ReadNumberOfReserved(string localCode)
        {
            return _context.Reserve.Where(e => e.ApartmentCode == localCode).ToList().Count;
        }

        public IActionResult Create()
        {
            return View();
        }
        private async Task<Apartment> GetApartment(string apartmentCode)
        {
            var apartment = await _context.Apartment.Include(e => e.ApartmentDetails).FirstOrDefaultAsync(e => e.LocalCode == apartmentCode);
            if (apartment == null)
            {
                throw new NullReferenceException(nameof(Apartment));
            }
            return apartment;
        }
        private async Task<Client> GetClient(int clientId)
        {
            var item = await _context.Client.FirstOrDefaultAsync(e => e.Id == clientId);
            if (item == null)
            {
                throw new NullReferenceException(nameof(Client));
            }
            return item;
        }
        private async Task<Invoice> GetInvoice(int id)
        {
            var item = await _context.Invoice.FirstOrDefaultAsync(e => e.Id == id);
            if (item == null)
            {
                throw new NullReferenceException(nameof(Invoice));
            }
            return item;
        }
        private async Task<Reserved> GetReservation(string rcc)
        {
            var item = await _context.Reserve.FirstOrDefaultAsync(e => e.RCC == rcc);
            if (item == null)
            {
                throw new NullReferenceException(nameof(Reserved));
            }
            return item;
        }
        private async Task<RCode> GetCode(string rCode)
        {
            var item = await _context.RCode.FirstOrDefaultAsync(e => e.Code == rCode);
            if (item == null)
            {
                throw new NullReferenceException(nameof(RCode));
            }
            return item;
        }
        private async Task<Confirmation> GetConfirm(int id)
        {
            var item = await _context.Confirmation.FirstOrDefaultAsync(e => e.Id == id);
            if (item == null)
            {
                throw new NullReferenceException(nameof(Confirmation));
            }
            return item;
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create([Bind("RCC, LocalCode")] Confirmation item)
        {
            try
            {

                var reserved = await GetReservation(item.RCC);

                var apartment = await GetApartment(item.LocalCode);
                if (reserved.ApartmentCode != apartment.LocalCode)
                {
                    return View("Error", "Mã căn không khớp, vui lòng kiểm tra lại");
                }
                if (!IsAvailable(apartment.LocalCode))
                {
                    return View("Error", "Căn này đã được đặt mua");
                }

                var client = await GetClientByReserved(reserved);
                
                item.ClientId = client.Id;
                return View("Confirm", new ConfirmationViewModel
                {
                    Apartment = apartment,
                    Client = client,
                    Confirm = item,
                    Reserve = reserved
                });

            }
            catch (NullReferenceException e)
            {

                return View("Error", $"Thông tin nhập không chính xác, vui lòng kiểm tra lại {e.Message}");
            }

        }

        private bool IsAvailable(string localCode)
        {
            var confirm = _context.Confirmation.FirstOrDefault(e => e.LocalCode == localCode);
            return confirm == null;
        }

        private async Task<Client> GetClientByReserved(Reserved rev)
        {
            var item = await _context.Client.FirstOrDefaultAsync(e => e.Cmnd == rev.Cmnd && e.PhoneNumber == rev.PhoneNumber);
            if (item == null)
            {
                throw new NullReferenceException(nameof(Client));
            }
            return item;
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Confirm([Bind("RCC, LocalCode, ClientId")] Confirmation item)
        {
            try
            {
                // if (Duplicate(item))
                // {
                //     return View("Create");
                // }
                _context.Confirmation.Add(item);
                await _context.SaveChangesAsync();
                try
                {
                    Invoice invoice = await CreateInvoice(item);
                    _context.Invoice.Add(invoice);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Get), new { id = invoice.Client.Id });

                }
                catch (NullReferenceException e)
                {
                    return View("Error", $"Vui lòng xác nhận trước khi tạo hóa đơn. [Error on: {e.Message}]");

                }



            }
            catch (DbUpdateConcurrencyException e)
            {
                return View("Error", e.Message);
            }

        }

        private bool Duplicate(Confirmation item)
        {
            var duplicated = _context.Confirmation.FirstOrDefault(e => e.LocalCode == item.LocalCode || e.RCC == item.RCC);
            if (duplicated != null)
            {
                return true;
            }
            return false;
        }

        private async Task<Invoice> CreateInvoice(Confirmation item)
        {
            try
            {
                var apartment = await GetApartment(item.LocalCode);
                var confirmation = await GetConfirm(item.Id);
                var client = await GetClient(confirmation.ClientId);
                return new Invoice
                {
                    Apartment = apartment,
                    Client = client,
                    Confirmation = confirmation
                };
            }
            catch (NullReferenceException e)
            {

                throw new NullReferenceException(e.Message);
            }


        }
    }
}