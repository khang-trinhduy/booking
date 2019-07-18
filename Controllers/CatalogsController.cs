using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookingForm.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using OfficeOpenXml;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using reCAPTCHA.AspNetCore;

namespace BookingForm.Controllers
{
    public class CatalogsController : Controller
    {
        private readonly bool Available = true;
        private readonly BookingFormContext _context;
        private static Random random = new Random();
        private IRecaptchaService _recaptcha;
        public static string GenerateCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 12)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public IActionResult Proceed(string code)
        {
            ViewBag.code = code;
            return View();
        }
        public IActionResult Detail(string room)
        {
            var apartment = _context.Apartment.Include(e => e.ApartmentDetails).FirstOrDefault(e => e.LocalCode == room);
            if (apartment == null)
            {
                return View("Error", $"Căn hộ số {room} đã bán hoặc không tồn tại");
            }
            return View(apartment);
        }
        private bool IsAvailable(string apartmentCode)
        {
            var confirm = _context.Confirmation.FirstOrDefault(e => e.LocalCode == apartmentCode);
            return confirm == null;
        }
        [Route("client/generate")]
        public async Task<IActionResult> Copy()
        {
            if (_context.Client.FirstOrDefault(e => true) != null)
            {
                return NotFound();
            }
            try
            {
                var booking = await _context.appoinment.Where(e => e.IsActive && e.Confirm && (e.NCH1 + e.NCH2 + e.NCH21 + e.NCH3) > 0).ToListAsync();
                List<Client> clients = new List<Client>();
                foreach (var item in booking)
                {
                    var exist = clients.FirstOrDefault(e => e.Cmnd.ToLower() == item.Cmnd.ToLower() || e.FullName.ToLower() == item.Customer.ToLower() || e.PhoneNumber.ToLower() == item.Phone.ToLower());
                    if (exist == null)
                    {
                        clients.Add(new Client{
                            Cmnd = item.Cmnd,
                            PhoneNumber = item.Phone,
                            FullName = item.Customer,
                            IsValid = true,
                            NOProduct = item.NCH1 + item.NCH2 + item.NCH21 + item.NCH3
                        });
                    }
                    else
                    {
                        exist.NOProduct += item.NCH1 + item.NCH2 + item.NCH21 + item.NCH3;
                    }
                }
                foreach (var item in clients)
                {
                    _context.Client.Add(item);
                }
                await _context.SaveChangesAsync();
                return Ok($"Successfully added {clients.Count} client");
                
            }
            catch (System.Exception e)
            {
                return NotFound(e.Message);
            }
        }

        public async Task<IActionResult> Code(int id)
        {
            var clients = await _context.Client.Include(e => e.Codes).ToListAsync();
            var client = clients.FirstOrDefault(e => e.Id == id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client.Codes);
        }
        public List<RCode> Generate(int nOfCode)
        {
            if (nOfCode <= 0)
            {
                throw new Exception(nameof(nOfCode));
            }
            var codex = new List<RCode>();
            var codes = _context.RCode.Where(c => true).ToList();
            for (int i = 0; i < nOfCode; i++)
            {
                var uniqueSerial = GenerateCode();
                var existed = _context.RCode.FirstOrDefault(e => e.Code == uniqueSerial);
                while (existed != null)
                {
                    uniqueSerial = GenerateCode();
                    existed = _context.RCode.FirstOrDefault(e => e.Code == uniqueSerial);
                }
                codex.Add(new RCode
                {
                    Code = uniqueSerial,
                    IsUsed = false
                });
            }
            return codex;
        }
        [Route("giohang/matbang")]
        public IActionResult ImageMap(string floor = "")
        {
            try
            {
                return View($"{floor}");
                
            }
            catch (System.Exception)
            {
                return View("Error", $"floor {floor} is invalid");
            }
        }
        [Route("client/code/generate")]
        public async Task<IActionResult> Assign()
        {
            if (!Available)
            {
                throw new Exception("reservation codes aren't available!");
            }
            var clients = await _context.Client.Where(e => e.IsValid).ToListAsync();
            foreach (var item in clients)
            {
                var codes = Generate(item.NOProduct * 2);
                foreach (var code in codes)
                {
                    _context.RCode.Add(code);
                }
                foreach (var code in codes)
                {
                    item.Codes.Add(code);
                }
                _context.Entry(item).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Client));
        }

        [Route("khachhang")]
        public async Task<IActionResult> Client()
        {
            var clients = await _context.Client.Include(e => e.Codes).Where(e => true).ToListAsync();
            return View(clients);
        }
        public async Task<IActionResult> GetClient()
        {
            var appointment = await _context.appoinment.Where(e => e.IsActive == true && e.Confirm == true && (e.NCH1 + e.NCH2 + e.NCH21 + e.NCH3) > 0).ToListAsync();
            foreach (var item in appointment)
            {
                var existed = _context.Client.FirstOrDefault(e => e.FullName.ToLower() == item.Customer.ToLower() && e.Cmnd == item.Cmnd && e.PhoneNumber == item.Phone);
                if (existed != null)
                {
                    existed.NOProduct += item.NCH1 + item.NCH2 + item.NCH21 + item.NCH3;
                    _context.Entry(existed).State = EntityState.Modified;
                }
                else
                {
                    _context.Client.Add(new Client
                    {
                        Cmnd = item.Cmnd,
                        FullName = item.Customer,
                        NOProduct = item.NCH1 + item.NCH2 + item.NCH21 + item.NCH3,
                        PhoneNumber = item.Phone,
                        IsValid = true
                    });

                }

            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Client));
        }
        public CatalogsController(BookingFormContext context, IRecaptchaService recaptcha)
        {
            _context = context;
            _recaptcha = recaptcha;
        }
       
        [Route("giohang/dot/{id:int}")]
        public async Task<IActionResult> GetApartments(int id)
        {
            var batch = await _context.Batch.Include(e => e.Storage).ThenInclude(e => e.Apartments).FirstOrDefaultAsync(e => e.IsRunning && e.Id == id);
            if (batch == null)
            {
                return NotFound($"Cannot find any running batch with id {id}");
            }
            var apartments = batch.Storage.Apartments.OrderBy(e => e.GlobalCode);

            return View("Apartment", apartments);
        }
        
        public async Task<IActionResult> Details(int id)
        {
            var detail = await _context.Details.FindAsync(id);
            if (detail == null)
            {
                return NotFound();
            }
            return View("ApartmentDetails", detail);
        }
        [Route("giohang/import")]
        public IActionResult Import()
        {
            return View();
        }
        private bool IsContain(string a, string b)
        {
            var token = a.Split("-");
            if (token.Length != 2)
            {
                return false;
            }
            try
            {
                int x = Convert.ToInt16(token[0]), y = Convert.ToInt16(token[1]), z = Convert.ToInt16(b);
                if (x <= z && z <= y)
                {
                    return true;
                }
                return false;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        [HttpPost]
        [Route("giohang/import")]
        public async Task<IActionResult> Import(IFormFile file)
        {
            if (file == null)
            {
                ViewBag.msg = "File not found!";
                return View(nameof(Import));
            }
            int add = 0, update = 0;
            var filePath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets.First(c => true);
                int totalRows = workSheet.Dimension.Rows;
                List<Apartment> apartments = new List<Apartment>();
                for (int i = 2; i <= totalRows; i++)
                {
                    Apartment c = new Apartment();
                    try
                    {
                        c.LocalCode = workSheet.Cells[i, 1].Value.ToString();
                        c.GlobalCode = workSheet.Cells[i, 2].Value.ToString();
                        c.Name = workSheet.Cells[i, 3].Value.ToString();
                        c.NOBedroom = workSheet.Cells[i, 4].Value.ToString();
                        // c.NOWC = workSheet.Cells[i, 5].Value.ToString();
                        c.Direction = workSheet.Cells[i, 6].Value.ToString();
                        c.View = workSheet.Cells[i, 7].Value.ToString();
                        c.Area = workSheet.Cells[i, 8].Value.ToString();
                        c.Floor = workSheet.Cells[i, 9].Value.ToString();
                        c.Block = workSheet.Cells[i, 10].Value.ToString();
                        c.Price = workSheet.Cells[i, 11].Value.ToString();
                        c.Area1 = workSheet.Cells[i, 12].Value.ToString();
                        // c.Location = workSheet.Cells[i, 12].Value.ToString();
                        
                    }
                    catch (System.Exception)
                    {
                        ViewBag.msg = $"Error! Cells must not be empty on row {i}";
                        return View(nameof(Import));
                    }

                    try
                    {
                        var existed = await _context.Apartment.FirstOrDefaultAsync(e => e.LocalCode.ToLower() == c.LocalCode.ToLower());
                        if (existed != null)
                        {
                            existed.Area = c.Area;
                            existed.Block = c.Block;
                            existed.Direction = c.Direction;
                            existed.Floor = c.Floor;
                            existed.GlobalCode = c.GlobalCode;
                            existed.Location = c.Location;
                            existed.NOBedroom = c.NOBedroom;
                            existed.NOWC = c.NOWC;
                            existed.Name = c.Name;
                            existed.Price = c.Price;
                            existed.View = c.View;
                            existed.Area1 = c.Area1;
                            _context.Entry(existed).State = EntityState.Modified;
                            update++;
                        }
                        else
                        {
                            add++;
                            apartments.Add(c);

                        }
                    }
                    catch (Exception e)
                    {
                        ViewBag.msg = e.Message;
                        return View(nameof(Import));
                    }

                }
                try
                {
                    await _context.Apartment.AddRangeAsync(apartments);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewBag.msg = e.Message;
                    return View(nameof(Import));
                }
            }
            ViewBag.msg = $"Import successful! Added {add} apartment, updated {update} existing apartment";
            return View(nameof(Import));

        }
        public async Task<IActionResult> Export()
        {
            //string fname = @"Thông tin đặt giữ chỗ dự án Vincity" + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx";
            var filePath = Path.GetTempPath();
            filePath = filePath + "catalog.xlsx";
            string URL = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, filePath);
            FileInfo file = new FileInfo(filePath);
            var memory = new MemoryStream();
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook;
                workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet("Catalog");
                IRow row = excelSheet.CreateRow(0);

                row.CreateCell(0).SetCellValue("Mã căn (nội bộ)");
                row.CreateCell(1).SetCellValue("Mã căn (từ chủ đầu tư)");
                row.CreateCell(2).SetCellValue("Tên căn hộ");
                row.CreateCell(3).SetCellValue("Số phòng ngủ");
                row.CreateCell(4).SetCellValue("Số phòng vệ sinh");
                row.CreateCell(5).SetCellValue("Hướng");
                row.CreateCell(6).SetCellValue("View");
                row.CreateCell(7).SetCellValue("Diện tích");
                row.CreateCell(8).SetCellValue("Tầng");
                row.CreateCell(9).SetCellValue("Khối");
                row.CreateCell(10).SetCellValue("Giá");
                row.CreateCell(11).SetCellValue("Vị trí");
                var catalogs = await _context.Apartment.Include(c => c.ApartmentDetails).ToListAsync();
                int count = 1;
                foreach (var catalog in catalogs)
                {
                    row = excelSheet.CreateRow(count);
                    row.CreateCell(0).SetCellValue(catalog.LocalCode);
                    row.CreateCell(1).SetCellValue(catalog.GlobalCode);
                    row.CreateCell(2).SetCellValue(catalog.Name);
                    row.CreateCell(3).SetCellValue(catalog.NOBedroom);
                    row.CreateCell(4).SetCellValue(catalog.NOWC);
                    row.CreateCell(5).SetCellValue(catalog.Direction);
                    row.CreateCell(6).SetCellValue(catalog.View);
                    row.CreateCell(7).SetCellValue(catalog.Area);
                    row.CreateCell(8).SetCellValue(catalog.Floor);
                    row.CreateCell(9).SetCellValue(catalog.Block);
                    row.CreateCell(10).SetCellValue(catalog.Price);
                    row.CreateCell(11).SetCellValue(catalog.Location);

                    count++;
                }

                workbook.Write(fs);
            }
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", filePath);
        }

    }
}
