using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookingForm.Models;
using Microsoft.AspNetCore.Identity;
using Serilog;
using QRCoder;
using System.Drawing;
using System.IO;
using jsreport.AspNetCore;
using jsreport.Types;
using Microsoft.AspNetCore.Hosting;
using MimeKit;
using MailKit.Net.Smtp;

namespace BookingForm.Controllers.PrintController
{
    public class PrintsController : Controller
    {
        private readonly UserManager<Sale> _userManager;
        private readonly PrintContext _context;
        private readonly BookingFormContext _booking;
        private readonly IHostingEnvironment _env;
        public readonly IJsReportMVCService _jsReportMVCService;


        public PrintsController(IJsReportMVCService jsreport, IHostingEnvironment env, PrintContext context, BookingFormContext booking, UserManager<Sale> userManager)
        {
            _jsReportMVCService = jsreport;
            _env = env;
            _booking = booking;
            _userManager = userManager;
            _context = context;
        }

        public async Task<bool> IsAuthorized(Sale sale, string resource, string operation)
        {
            if (sale == null)
            {
                return false;
            }
            var roles = await _userManager.GetRolesAsync(sale);

            var grants = await _booking.Grants.Where(g => g.Operation == operation && g.Resource == resource && g.Permission == "Allow").ToListAsync();
            if (grants != null)
            {
                foreach (var grant in grants)
                {
                    if (roles.Contains(grant.RoleName))
                    {
                        return true;
                    }
                }
            }
            Log.Warning("Access denied! User " + sale.Name + " tried to " + operation + " " + resource + ".");
            return false;
        }

        // GET: Prints
        public async Task<IActionResult> Index()
        {
            var curUser = await _userManager.GetUserAsync(User);
            if (curUser is null)
            {
                return View("Error", "Bạn phải đăng nhập để thực hiện tác vụ này");
            }
            var authorized = await IsAuthorized(curUser, "Prints", "Read");
            if (!authorized)
            {
                return View("AccessDenied");
            }
            if (string.IsNullOrEmpty(curUser.Name) || string.IsNullOrWhiteSpace(curUser.Name))
            {
                return View("Error", "Vui lòng cập nhật họ tên để sử dụng tiếp tục sử dụng");
            }
            var printer = curUser.Name.Split(" ").Last();
            return View(await _context.Print.Where(e => e.Printer == printer).ToListAsync());
        }

        // GET: Prints/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var curUser = await _userManager.GetUserAsync(User);
            if (curUser is null)
            {
                return View("Error", "Bạn phải đăng nhập để thực hiện tác vụ này");
            }
            var authorized = await IsAuthorized(curUser, "Prints", "Create");
            if (!authorized)
            {
                return View("AccessDenied");
            }
            var print = await _context.Print
                .FirstOrDefaultAsync(m => m.Id == id);
            if (print == null)
            {
                return NotFound();
            }

            return View(print);
        }

        // GET: Prints/Create
        public IActionResult Create()
        {
            var curUser = _userManager.GetUserAsync(User);
            if (curUser is null)
            {
                return View("Error", "Bạn phải đăng nhập để thực hiện tác vụ này");
            }

            return View();
        }

        // POST: Prints/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantity,FileName,Printer,PrintDate,CompanyName,Type")] Print print)
        {
            if (print.Quantity <= 0)
            {
                return NotFound("Vui lòng nhập số lượng files cần in");
            }
            var curUser = await _userManager.GetUserAsync(User);
            if (curUser is null)
            {
                return View("Error", "Bạn phải đăng nhập để thực hiện tác vụ này");
            }
            var authorized = await IsAuthorized(curUser, "Prints", "Create");
            if (!authorized)
            {
                return View("AccessDenied");
            }
            Guid tempCode = new Guid();
            if (ModelState.IsValid)
            {
                Update(print, curUser);
                if (string.IsNullOrEmpty(print.Printer) || string.IsNullOrWhiteSpace(print.Printer))
                {
                    return View("Error", "Vui lòng cập nhật họ tên để sử dụng tiếp tục sử dụng");
                }
                var date = print.PrintDate.ToString("dd/MM/yyyy");
                var lastName = curUser.Name.Split(" ").Last();

                var printed = _context.Print.Where(e => e.Printer == lastName && e.PrintDate.ToString("dd/MM/yyyy") == date).Include(e => e.Files).FirstOrDefault();
                var printer = print.Printer.Split(" ").Last();
                int printedFiles = 0;
                if (printed != null)
                {
                    printedFiles = printed.Quantity;
                    if (print.Quantity + printedFiles > 100)
                    {
                        return View("Error", $"Vui lòng nhập số lượng file nhỏ hơn {100 - printedFiles + 1}");
                    }
                    printed.Quantity += print.Quantity;
                    printed.PrintDate = print.PrintDate;

                    for (int i = 0; i < print.Quantity; i++)
                    {
                        var index = (i + 1 + printedFiles).ToString("000");
                        var text = $"{printed.CompanyName}-{date}-{printer}-{index}";
                        printed.Files.Add(new Download
                        {
                            File = printed.FileName,
                            QRCode = text,
                            Image = GenerateQRCode(text)
                        });
                        // var filePath = $"{Path.GetTempPath()}{text}.pdf";
                        // GenerateQRCode(text);
                        //TODO add code to file
                        // SaveFile(filePath);
                        //TODO save file to google drive
                    }
                    tempCode = printed.Code;

                    _context.Entry(printed).State = EntityState.Modified;
                }
                else
                {
                    print.Files = new List<Download>();
                    var numberOfFiles = print.Quantity;
                    if (numberOfFiles <= 0 || numberOfFiles > 100)
                    {
                        return View("Error", "Invalid number of files{numberOfFiles}, it must be between 0 and 101");
                    }

                    for (int i = 0; i < numberOfFiles; i++)
                    {
                        var index = (i + 1 + printedFiles).ToString("000");
                        var text = $"{print.CompanyName}-{date}-{printer}-{index}";
                        print.Files.Add(new Download
                        {
                            File = print.FileName,
                            QRCode = text,
                            Image = GenerateQRCode(text)
                        });
                        // var filePath = $"{Path.GetTempPath()}{text}.pdf";
                        // GenerateQRCode(text);
                        //TODO add code to file
                        // SaveFile(filePath);
                        //TODO save file to google drive

                    }
                    tempCode = print.Code;

                    _context.Add(print);
                }

                await _context.SaveChangesAsync();
                ViewBag.code = print.Code;
                string contents = "Dear Ms. Hương\n";
                contents += $"Ngày {date} Hệ thống đã nhận được yêu cầu in {print.Quantity} Phiếu đăng ký giữ chỗ dự án Vinhomes Grand Park từ {curUser.Name}.";
                contents += "\nRegards.\n";
                SendMail("Thông báo in hợp đồng", new MailboxAddress("Ms. Hương", "huong.ngo@annhome.vn"), contents); 
                return RedirectToAction("Download", new { code = tempCode });
            }

            return View("Error", $"Invalid model state {ModelState}!");
        }

        public ActionResult Draft()
        {
            return View(null);
        }

        public ActionResult Download(Guid code)
        {
            var item = _context.Print.Include(e => e.Files).Where(e => e.Code == code).FirstOrDefault();
            if (item == null)
            {
                return View("Error", "Invalid download code!");
            }
            if (item.Files == null)
            {
                return View("Error", "Invalid download file!");
            }
            if (item.Files.Count <= 0)
            {
                return View("Error", "Can't find any files to download!");
            }
            return View(item.Files.OrderBy(e => e.QRCode));
        }

        /// <summary>
        /// open file on new tab
        /// </summary>
        /// <returns>pdf file</returns>

        [MiddlewareFilter(typeof(JsReportPipeline))]
        public ActionResult ViewPdf(string code)
        {
            var file = _context.Download.Where(e => e.QRCode == code).FirstOrDefault();
            if (file == null)
            {
                throw new Exception($"Cannot find any file with code {code}");
            }
            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf);
            return View("Draft", file.Image);
        }
        /// <summary>
        /// open file on new tab
        /// </summary>
        /// <returns>pdf file</returns>

        [MiddlewareFilter(typeof(JsReportPipeline))]
        public ActionResult ViewMultiplePdfs(int from, int to, Guid code)
        {
            var item = _context.Print.Include(e => e.Files).Where(e => e.Code == code).FirstOrDefault();
            if (item == null)
            {
                return View("Error", "Invalid download code!");
            }
            if (item.Files == null)
            {
                return View("Error", "Invalid download file!");
            }
            if (item.Files.Count <= 0)
            {
                return View("Error", "Can't find any files to download!");
            }
            // return View(item.Files.OrderBy(e => e.QRCode));

            var files = item.Files.OrderBy(e => e.QRCode).ToList();

            if (from - 1 > files.Count || to - 1 > files.Count || from < 0 || to < 0)
            {
                throw new Exception("Files doesn't exist!");
            }

            var downloadFiles = files.Skip(from - 1).Take(to - from).ToList();


            List<Byte[]> images = new List<Byte[]>();
            foreach (var fileToDownload in downloadFiles)
            {
                images.Add(fileToDownload.Image);
            }
            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf);
            if (images.Count == 3)
            {
                ViewBag.img1 = images[0];
                ViewBag.img2 = images[1];
                ViewBag.img3 = images[2];
                return View("Draft3", images);
            }
            else if(images.Count == 5)
            {
                ViewBag.img1 = images[0];
                ViewBag.img2 = images[1];
                ViewBag.img3 = images[2];
                ViewBag.img4 = images[3];
                ViewBag.img5 = images[4];
                return View("Draft5", images[1]);
            }
            else if(images.Count == 10)
            {
                ViewBag.img1 = images[0];
                ViewBag.img2 = images[1];
                ViewBag.img3 = images[2];
                ViewBag.img4 = images[3];
                ViewBag.img5 = images[4];
                ViewBag.img6 = images[5];
                ViewBag.img7 = images[6];
                ViewBag.img8 = images[7];
                ViewBag.img9 = images[8];
                ViewBag.img10 = images[9];
                return View("Draft10", images[2]);
            }
            else
            {
                throw new Exception($"invalid number of files to print{images.Count}");
            }
        }
        /// <summary>
        /// download file
        /// </summary>
        /// <returns>pdf file</returns>

        [MiddlewareFilter(typeof(JsReportPipeline))]
        public IActionResult DownloadPdf(string code)
        {
            var file = _context.Download.Where(e => e.QRCode == code).FirstOrDefault();
            if (file == null)
            {
                throw new Exception($"Cannot find any file with code {code}");
            }

            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf)
                .OnAfterRender((r) => HttpContext.Response.Headers["Content-Disposition"] = $"attachment; filename=\"{file.QRCode}.pdf\""
                );
            return View("Draft", file.Image);
        }

        private static void SendMail(string subject, MailboxAddress reciever, string contents)
        {
            var message = new MimeMessage();
            message.To.Add(reciever);
            message.From.Add(new MailboxAddress("AnnSmart", "annsmart@annhome.vn"));
            message.Subject = subject;
            message.Cc.Add(new MailboxAddress("Ms. Duyên", "duyen.dang@annhome.vn"));
            message.Cc.Add(new MailboxAddress("Ms. Hằng", "hang.le@annhome.vn"));
            message.Body = new TextPart("plain")
            {
                Text = contents
            };
            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp-mail.outlook.com", 587, false);

                client.Authenticate("annsmart@annhome.vn", "kh@ng1512");//Nnhm2018

                client.Send(message);
                client.Disconnect(true);

            }
        }

        // [MiddlewareFilter(typeof(JsReportPipeline))]
        // public IActionResult DownloadAll(Guid code)
        // {
        //     var item = _context.Print.Include(e => e.Files).Where(e => e.Code == code).FirstOrDefault();
        //     if (item == null)
        //     {
        //         throw new Exception("Error");
        //     }
        //     if (item.Files == null)
        //     {
        //         throw new Exception("Error");
        //     }
        //     if (item.Files.Count <= 0)
        //     {
        //         throw new Exception("Error");
        //     }

        //     foreach (var file in item.Files)
        //     {
        //         HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf)
        //             .OnAfterRender((r) => HttpContext.Response.Headers["Content-Disposition"] = $"attachment; filename=\"{file.QRCode}.pdf\"");
        //         yield return View("Draft", file.Image);

        //     }
        // }

        /// <summary>
        /// open file with microsoft excel
        /// </summary>
        /// <returns></returns>
        [MiddlewareFilter(typeof(JsReportPipeline))]
        public IActionResult ItemsExcelOnline()
        {
            HttpContext.JsReportFeature()
                .Configure(req => req.Options.Preview = true)
                .Recipe(Recipe.HtmlToXlsx)
                .Configure((r) => r.Template.HtmlToXlsx = new HtmlToXlsx() { HtmlEngine = "chrome" });

            return View("Items");
        }

        private static void Update(Print print, Sale curUser)
        {
            print.Code = Guid.NewGuid();
            print.FileName = "Mẫu_Phiếu giữ chỗ_AnnHome_VGP";
            print.CompanyName = "AnnHome";
            print.PrintDate = DateTime.Now;
            print.Printer = curUser.Name.Split(" ").Last();
            print.Type = "draft";
        }

        private void SaveFile(string filePath)
        {
            HttpContext.JsReportFeature().OnAfterRender((r) =>
            {
                using (var file = System.IO.File.Open(filePath, FileMode.Create))
                {
                    r.Content.CopyTo(file);
                }
                r.Content.Seek(0, SeekOrigin.Begin);
            });
        }
        /// <summary>
        /// convert bitmap images to bytes
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        private static Byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private Byte[] GenerateQRCode(string text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return BitmapToBytes(qrCodeImage);
        }

        // GET: Prints/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var curUser = await _userManager.GetUserAsync(User);
            if (curUser is null)
            {
                return View("Error", "Bạn phải đăng nhập để thực hiện tác vụ này");
            }
            var authorized = await IsAuthorized(curUser, "Prints", "Edit");
            if (!authorized)
            {
                return View("AccessDenied");
            }
            var print = await _context.Print.FindAsync(id);
            if (print == null)
            {
                return NotFound();
            }
            return View(print);
        }

        // POST: Prints/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Quantity,FileName,Printer,PrintDate,CompanyName,Type")] Print print)
        {
            var curUser = await _userManager.GetUserAsync(User);
            if (curUser is null)
            {
                return View("Error", "Bạn phải đăng nhập để thực hiện tác vụ này");
            }
            var authorized = await IsAuthorized(curUser, "Prints", "Edit");
            if (!authorized)
            {
                return View("AccessDenied");
            }
            if (id != print.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(print);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrintExists(print.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(print);
        }

        // GET: Prints/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var curUser = await _userManager.GetUserAsync(User);
            if (curUser is null)
            {
                return View("Error", "Bạn phải đăng nhập để thực hiện tác vụ này");
            }
            var authorized = await IsAuthorized(curUser, "Prints", "Delete");
            if (!authorized)
            {
                return View("AccessDenied");
            }
            if (id == null)
            {
                return NotFound();
            }

            var print = await _context.Print
                .FirstOrDefaultAsync(m => m.Id == id);
            if (print == null)
            {
                return NotFound();
            }

            return View(print);
        }

        // POST: Prints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var curUser = await _userManager.GetUserAsync(User);
            if (curUser is null)
            {
                return View("Error", "Bạn phải đăng nhập để thực hiện tác vụ này");
            }
            var print = await _context.Print.FindAsync(id);
            _context.Print.Remove(print);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrintExists(int id)
        {
            return _context.Print.Any(e => e.Id == id);
        }
    }
}
