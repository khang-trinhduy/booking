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
        [Route("freecode")]
        public IActionResult NotMyCode()
        {
            return View("Code");
        }
        [Route("Reservations/")]
        public async Task<IActionResult> Index()
        {
            var reserveds = await _context.Reserve.Where(e => true).ToListAsync();
            ReservationR revs = new ReservationR();
            var apartments = await _context.Apartment.Include(e => e.ApartmentDetails).Where(e => true).ToListAsync();
            foreach (var item in apartments)
            {
                if (item.ApartmentDetails != null)
                {
                    if (item.ApartmentDetails.ApartmentType == "3BR")
                    {
                        revs.BR3.Add(new Room
                        {
                            Reserveds = reserveds.Where(e => e.ApartmentCode == item.LocalCode).OrderBy(e => e.Id).TakeLast(3).Select(o=> Transform(o)).ToList(),
                            Apartment = Transform(item)
                        });
                    }
                    else if (item.ApartmentDetails.ApartmentType == "2BR+")
                    {
                        revs.BR2P.Add(new Room
                        {
                            Reserveds = reserveds.Where(e => e.ApartmentCode == item.LocalCode).OrderBy(e => e.Id).TakeLast(3).Select(o=> Transform(o)).ToList(),
                            Apartment = Transform(item)
                        });
                    }
                    else if (item.ApartmentDetails.ApartmentType == "2BR")
                    {
                        revs.BR2.Add(new Room
                        {
                            Reserveds = reserveds.Where(e => e.ApartmentCode == item.LocalCode).OrderBy(e => e.Id).TakeLast(3).Select(o=> Transform(o)).ToList(),
                            Apartment = Transform(item)
                        });
                    }
                    else if (item.ApartmentDetails.ApartmentType == "1BR+")
                    {
                        revs.BR1P.Add(new Room
                        {
                            Reserveds = reserveds.Where(e => e.ApartmentCode == item.LocalCode).OrderBy(e => e.Id).TakeLast(3).Select(o=> Transform(o)).ToList(),
                            Apartment = Transform(item)
                        });
                    }
                    else if (item.ApartmentDetails.ApartmentType == "STU")
                    {
                        revs.STU.Add(new Room
                        {
                            Reserveds = reserveds.Where(e => e.ApartmentCode == item.LocalCode).OrderBy(e => e.Id).TakeLast(3)
                            .Select(o=> Transform(o)).ToList(),
                            Apartment = Transform(item)
                        });
                    }
                }
            }
            return View(revs);
        }
        
        private Reserved Transform(Reserved item)
        {
          
            item.Customer = GetCustomerName(item);
            item.PhoneNumber = GetPhoneNumber(item);
            return item;
        }
        private Apartment Transform(Apartment item)
        {
          
            item.LocalCode = GetCode(item);
            return item;
        }

        private string GetCode(Apartment item)
        {
            
            var count = _context.Reserve.Where(e => e.ApartmentCode == item.LocalCode).DefaultIfEmpty().Max(e => e == null ? 0 : e.CC);
            return item.LocalCode + " (" + count.ToString() + ")";
        
        }

        private string GetCustomerName(Reserved item){
            if (string.IsNullOrWhiteSpace(item.Customer)) return string.Empty;

            var sp =  item.Customer.Split(" ");
            return sp[sp.Length - 1];
        }
        private string GetPhoneNumber(Reserved item){
            if (string.IsNullOrWhiteSpace(item.PhoneNumber)) return string.Empty;
            var newPhoneNumber = "XXXXX" + item.PhoneNumber.Substring(item.PhoneNumber.Length - 4);            
            return newPhoneNumber;
        }
        public IActionResult Continue()
        {
            return RedirectToAction("GetBlocks", "Catalogs", new { id = 0 });
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
                    ViewBag.msg = "Mã đặt chỗ không chính xác!";
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
                    ViewBag.msg = "Mã đặt chỗ không chính xác, vui lòng kiểm tra lại!";
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
                    ViewBag.msg = "Mã đặt chỗ đã được sử dụng!";
                    return View("Create");
                }
                r.Customer = client.FullName;
                return View(new Reservation { Reserved = r, Apartment = apartment });
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
            var apartment = await _context.Apartment.FirstOrDefaultAsync(e => e.LocalCode == reservation.ApartmentCode);
            return View("Success", new Reservation { Reserved = reservation, Apartment = apartment });
        }
        public IActionResult Create(string apartmentCode = null)
        {
            ViewBag.code = apartmentCode != null ? apartmentCode : "";
            return View();
        }
        private static Random random = new Random();
        public static string GenerateCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 4)
            .Select(s => s[random.Next(s.Length)]).ToArray());
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
                r.RCC = apartment.GlobalCode + "-" + GenerateCode() + "-" + r.CC.ToString();
                var unique = _context.Reserve.FirstOrDefault(e => e.RCC == r.RCC);
                do
                {
                    r.RCC = apartment.GlobalCode + "-" + GenerateCode() + "-" + r.CC.ToString();
                    unique = _context.Reserve.FirstOrDefault(e => e.RCC == r.RCC);

                } while (unique != null);
                apartment.NOfReserved++;
                _context.Reserve.Add(r);
                code.IsUsed = true;
                _context.Entry(code).State = EntityState.Modified;
                _context.Entry(apartment).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                ViewBag.cc = r.CC;
                ViewBag.date = r.Date.Day.ToString() + "-" + r.Date.Month.ToString() + "-" + r.Date.Year.ToString();
                return RedirectToAction(nameof(Get), new { confirmCode = r.RCC });
            }
            return View("Error", "Hệ thống xảy ra lỗi, vui lòng thử lại!");
        }
    }
}