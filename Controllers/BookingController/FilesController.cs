using BookingForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookingForm.Controllers
{
    public class FilesController : Controller
    {
        private readonly BookingFormContext _context;
        public FilesController(BookingFormContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(int quantity)
        {
            return View();
        }
    }
}