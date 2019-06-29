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

        public async Task<IActionResult> Index()
        {
            try
            {
                var confirmations = await _context.Confirmation.Where(e => true).ToListAsync();
                var confirmView = new List<ConfirmationViewModel>();
                foreach (var item in confirmations)
                {
                    var apartment = await GetApartment(item.LocalCode);
                    var client = await GetClient(item.ClientId);
                    var reserved = await GetReservation(item.RCC);
                    confirmView.Add(new ConfirmationViewModel
                    {
                        Apartment = apartment,
                        Client = client,
                        Confirm = item,
                        Reserve = reserved
                    });
                }
                return View(confirmView);
                
            }
            catch (System.NullReferenceException e)
            {
                return View("Error", $"Hệ thống xảy ra lỗi [error code {e.Message}]");
            }
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
        public async Task<IActionResult> Create([Bind("RCode, RCC, LocalCode")] Confirmation item)
        {
            try
            {
                var code = await _context.RCode.FirstOrDefaultAsync(e => e.Code == item.RCode);
                
                var reserved = await GetReservation(item.RCC);
               
                var apartment = await GetApartment(item.LocalCode);
                if (apartment.Reserved)
                {
                    return View("Error", "Căn này đã được đặt mua");
                }
                if (reserved.ApartmentCode != apartment.LocalCode)
                {
                    return View("Error", "Mã căn không khớp, vui lòng kiểm tra lại");                    
                }
                if (reserved.RCode != code.Code)
                {
                    return View("Error", "Mã đặt chỗ không khớp, vui lòng kiểm tra lại");                    
                }
                var client = await GetClientByReserved(reserved);
                item.ClientId = client.Id;
                return View("Confirm", new ConfirmationViewModel {
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
        public async Task<IActionResult> Confirm([Bind("RCode, RCC, LocalCode, ClientId")] Confirmation item)
        {
            try
            {
                _context.Confirmation.Add(item);
                await _context.SaveChangesAsync();
                try
                {
                    var apartment = await GetApartment(item.LocalCode);
                    Close(apartment);
                    _context.Entry(apartment).State = EntityState.Modified;
                    Invoice invoice = await CreateInvoice(item);
                    _context.Invoice.Add(invoice);
                    await _context.SaveChangesAsync();
                    return View("Success", invoice);
                    
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

        private void Close(Apartment item)
        {
            item.Reserved = true;
            _context.Entry(item).State = EntityState.Modified;
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