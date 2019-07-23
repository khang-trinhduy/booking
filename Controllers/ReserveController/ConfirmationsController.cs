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
        private Batch _batch;
        public ConfirmationsController(BookingFormContext context)
        {
            _context = context;
            _batch = _context.GetRunningBatch();
            if (_batch == null)
            {
                throw new NullReferenceException(nameof(Batch));
            }
        }
        [Route("Confirmations/{id:int?}")]
        public IActionResult Get(int id)
        {
            try
            {
                var invoice = _batch.GetInvoiceById(id);
                if (invoice == null)
                {
                    return View("Error", $"Mã hóa đơn không tồn tại, vui lòng kiểm tra lại.");
                }
                var invoiceViewModel = new InvoiceViewModel(invoice);
                return View("Success", invoiceViewModel);
            }
            catch (System.NullReferenceException e)
            {
                return View("Error", $"Mã hóa đơn không tồn tại, vui lòng kiểm tra lại. [Error code {e.Message}]");
            }

        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var confirmations = _batch.GetConfirmations();
                var confirmView = new List<ConfirmationList>();
                foreach (var item in confirmations)
                {
                    var apartment = GetApartment(item.LocalCode);
                    var client = await GetClient(item.ClientId);
                    var reserved = GetReservation(item.RCC);
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
            return _batch.GetReservations(localCode).ToList().Count;
        }

        public IActionResult Create()
        {
            return View();
        }
        private Apartment GetApartment(string apartmentCode)
        {
            var apartment = _batch.GetApartment(apartmentCode);
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
        private Reserved GetReservation(string rcc)
        {
            var item = _batch.GetReservation(rcc);
            if (item == null)
            {
                throw new NullReferenceException(nameof(Reserved));
            }
            return item;
        }
        private RCode GetCode(string rCode)
        {
            var item = _batch.GetCode(rCode);
            if (item == null)
            {
                throw new NullReferenceException(nameof(RCode));
            }
            return item;
        }
        private Confirmation GetConfirm(int id)
        {
            var item = _batch.GetConfirmations().FirstOrDefault(e => e.Id == id);
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

                var reserved = GetReservation(item.RCC);

                var apartment = GetApartment(item.LocalCode);
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
            return !_batch.ContainConfirmation(localCode);
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
                _batch.Confirmations.Add(item);
                _context.Entry(_batch).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                try
                {
                    Invoice invoice = await CreateInvoice(item);
                    _batch.Invoices.Add(invoice);
                    _context.Entry(_batch).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Get), new { id = invoice.Id });

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

        private async Task<Invoice> CreateInvoice(Confirmation item)
        {
            try
            {
                var apartment = GetApartment(item.LocalCode);
                var confirmation = GetConfirm(item.Id);
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