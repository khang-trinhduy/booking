using System.Drawing;
using System.IO;
using BookingForm.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BookingForm.Controllers
{
    public class LettersController : Controller
    {
        private readonly IHostingEnvironment _env;
        public LettersController(IHostingEnvironment environment)
        {
            this._env = environment;
        }

        [HttpGet]
        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create([Bind("Name, Phone, Hotline, Font, Color, Size")] Letter letter)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            PointF nameLoc = new PointF(10f, 10f);
            PointF phoneLoc = new PointF(10f, 50f);
            PointF hotlineLoc = new PointF(10f, 150f);

            var fileName = "letter-template.jpg";

            string templatePath = Path.Combine(_env.WebRootPath, "images") + $@"\{fileName}";
            string letterPath = Path.Combine(_env.WebRootPath, "images") + $@"\{letter.Phone}.jpg";

            Bitmap bitmap = (Bitmap)Image.FromFile(templatePath);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont = new Font("Arial", 10))
                {
                    graphics.DrawString(letter.Name, arialFont, Brushes.Blue, nameLoc);
                    graphics.DrawString(letter.Phone, arialFont, Brushes.Red, phoneLoc);
                    graphics.DrawString(letter.Hotline, arialFont, Brushes.Red, hotlineLoc);
                }
            }

            bitmap.Save(letterPath);
            return RedirectToAction("Letter", new {id = letter.Phone});
        }

        [HttpGet]
        public ActionResult Letter(string id)
        {
            if (string.IsNullOrEmpty(id) && string.IsNullOrWhiteSpace(id))
            {
                return View("Error", "Mã thiệp mời không được bỏ trống!");
            }
            return View("Letter", id);
        }
    }
}