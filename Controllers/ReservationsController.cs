using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using reCAPTCHA.AspNetCore;

namespace BookingForm.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly BookingFormContext _context;
        private IRecaptchaService _recaptcha;
        public ReservationsController(BookingFormContext context, IRecaptchaService recaptcha)
        {
            _recaptcha = recaptcha;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var reserveds = await _context.Reserve.Where(e => true).ToListAsync();
            List<Reservation> revs = new List<Reservation>();
            foreach (var item in reserveds)
            {
                revs.Add(
                    new Reservation
                    {
                        Apartment = _context.Apartment.FirstOrDefault(e => e.LocalCode == item.ApartmentCode),
                        Reserved = item
                    }
                );
            }
            return View(revs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Confirm([Bind("ApartmentCode, Cmnd, PhoneNumber, RCode")] Reserved r)
        {
            if (ModelState.IsValid)
            {
                ViewBag.code = r.ApartmentCode;
                var apartment = _context.Apartment.FirstOrDefault(e => e.LocalCode == r.ApartmentCode && e.Reserved == false);
                if (apartment == null)
                {
                    ViewBag.msg = "Căn hộ đã có người mua!";
                    return View("Create");
                }
                var code = _context.RCode.FirstOrDefault(e => e.Code == r.RCode);
                if (code == null)
                {
                    ViewBag.msg = "Mã mua không chính xác!";
                    return View("Create");
                }
                var clients = await _context.Client.Include(e => e.Codes).ToListAsync();
                var client = clients.FirstOrDefault(e => e.Cmnd == r.Cmnd && e.PhoneNumber == r.PhoneNumber);
                if (client == null)
                {
                    ViewBag.msg = "Số cmnd hoặc số điện thoại không chính xác! Vui lòng kiểm tra lại.";
                    return View("Create");
                }
                else if (!client.IsValid)
                {
                    ViewBag.msg = "Mỗi khách chỉ được mua một căn hộ!";
                    return View("Create");
                }
                var isValidCode = client.Codes.FirstOrDefault(e => e.Code == code.Code && e.Id == code.Id);
                if (isValidCode == null)
                {
                    ViewBag.msg = "Mã đặt mua không chính xác, vui lòng kiểm tra lại!";
                    return View("Create");
                }
                if (code.IsUsed)
                {
                    var re = _context.Reserve.FirstOrDefault(e => e.RCode == code.Code);
                    if (re != null)
                    {
                        var apart = _context.Apartment.FirstOrDefault(e => e.LocalCode == re.ApartmentCode);
                        if (apart != null)
                        {
                            ViewBag.cc = re.CC;
                            ViewBag.date = r.Date.Day.ToString() + "-" + r.Date.Month.ToString() + "-" + r.Date.Year.ToString();
                            return RedirectToAction("Get", re.RCode);
                        }
                    }
                    ViewBag.msg = "Mã này đã được sử dụng!";
                    return View("Create");
                }
                r.Customer = client.FullName;
                return View(new Reservation {Reserved = r, Apartment = apartment});
            }
            return View("Error", "Hệ thống xảy ra lỗi, vui lòng thử lại!");
        }
        public async Task<IActionResult> Get(string confirmCode)
        {
            var reservation = await _context.Reserve.FirstOrDefaultAsync(e => e.RCC == confirmCode);
            if (reservation == null)
            {
                return View("Error", "Sai mã xác nhận");
            }
            ViewBag.date = reservation.Date.Day.ToString() + "-" + reservation.Date.Month.ToString() + "-" + reservation.Date.Year.ToString();
            var apartment = await _context.Apartment.FirstOrDefaultAsync(e => e.LocalCode == reservation.ApartmentCode);
            return View("Success", new Reservation { Reserved = reservation, Apartment = apartment });
        }
        public IActionResult Create(string apartmentCode = null)
        {
            ViewBag.code = apartmentCode != null ? apartmentCode : "";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApartmentCode, Cmnd, PhoneNumber, RCode, Customer")] Reserved r)
        {
            if (ModelState.IsValid)
            {
                ViewBag.code = r.ApartmentCode;
                // var recaptcha = await _recaptcha.Validate(Request);
                // if (!recaptcha.success)
                // {
                //     ViewBag.msg = "Sai mã captcha!";
                //     return View("Proceed");
                // }
                
                var apartment = _context.Apartment.FirstOrDefault(e => e.LocalCode == r.ApartmentCode);
                if (apartment == null)
                {
                    return View("Error", $"Mã căn hộ không hợp lệ {r.ApartmentCode}");
                }
                if (apartment.Reserved)
                {
                    return View("Error", "Căn hộ đã được đặt mua!");
                }
                var code = _context.RCode.FirstOrDefault(e => e.Code == r.RCode);
                r.Date = DateTime.Now.Date;
                r.CC = apartment.NOfReserved + 1;
                r.RCC = apartment.GlobalCode + "-" + r.CC.ToString();
                apartment.NOfReserved++;
                _context.Reserve.Add(r);
                code.IsUsed = true;
                _context.Entry(code).State = EntityState.Modified;
                _context.Entry(apartment).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                ViewBag.cc = r.CC;
                ViewBag.date = r.Date.Day.ToString() + "-" + r.Date.Month.ToString() + "-" + r.Date.Year.ToString();
                return RedirectToAction(nameof(Get),  new { reservationCode = r.RCode});
            }
            return View("Error", "Hệ thống xảy ra lỗi, vui lòng thử lại!");
        }
    }
}