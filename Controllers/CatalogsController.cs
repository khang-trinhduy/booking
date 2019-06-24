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

namespace BookingForm.Controllers
{
    public class CatalogsController : Controller
    {
        private readonly BookingFormContext _context;

        public CatalogsController(BookingFormContext context)
        {
            _context = context;
        }

        // GET: Catalogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Catalog.ToListAsync());
        }
        public IActionResult Import()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Import(IFormFile file)
        {
            if (file == null)
            {
                ViewBag.msg = "File not found!";
                return View(nameof(Import));
            }
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
                List<Catalog> Catalogs = new List<Catalog>();
                for (int i = 2; i <= totalRows; i++)
                {
                    Catalog c = new Catalog();

                    c.LocalCode = workSheet.Cells[i, 1].Value.ToString();
                    c.GlobalCode = workSheet.Cells[i, 2].Value.ToString();
                    c.Name = workSheet.Cells[i, 3].Value.ToString();
                    c.NOBedroom = workSheet.Cells[i, 4].Value.ToString();
                    c.NOWC = workSheet.Cells[i, 5].Value.ToString();
                    c.Direction = workSheet.Cells[i, 6].Value.ToString();
                    c.View = workSheet.Cells[i, 7].Value.ToString();
                    c.Area = workSheet.Cells[i, 8].Value.ToString();
                    c.Floor = workSheet.Cells[i, 9].Value.ToString();
                    c.Block = workSheet.Cells[i, 10].Value.ToString();

                    try
                    {
                        Catalogs.Add(c
                        );
                    }
                    catch (Exception e)
                    {
                        ViewBag.msg = e.Message;
                        return View(nameof(Import));
                    }

                }
                try
                {
                    await _context.Catalog.AddRangeAsync(Catalogs);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewBag.msg = e.Message;
                    return View(nameof(Import));
                }
            }
            ViewBag.msg = "Import successful!";
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
                var catalogs = await _context.Catalog.Where(c => true).ToListAsync();
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
        // GET: Catalogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catalog = await _context.Catalog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (catalog == null)
            {
                return NotFound();
            }

            return View(catalog);
        }

        // GET: Catalogs/Create
        
    }
}
