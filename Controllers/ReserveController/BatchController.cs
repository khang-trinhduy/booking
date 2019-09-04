using System;
using System.Linq;
using System.Threading.Tasks;
using BookingForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingForm.Controllers
{
    public class BatchController : Controller
    {
        private readonly BookingFormContext _context;
        public BatchController(BookingFormContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var batches = _context.Batch.Where(e => true).ToList();
            return View(batches);
        }
        public async Task<IActionResult> Create()
        {
            var apartments = await _context.Apartment.Where(e => _context.Confirmation.FirstOrDefault(c => c.LocalCode == e.LocalCode) == null).ToListAsync();
            var codes = await _context.RCode.Where(e => !e.IsUsed).ToListAsync();
            return View(new BatchCreateModel {Apartment = apartments, Code = codes});
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(bool IsRunning)
        {
            
            try
            {
                var apartments = await _context.Apartment.Where(e => _context.Confirmation.FirstOrDefault(c => c.LocalCode == e.LocalCode) == null).ToListAsync();
                var storage = new Storage(apartments);
                var codes = await _context.RCode.Include(e => e.Batch).Where(e => !e.IsUsed && e.Batch == null).ToListAsync();
                var batch = new Batch(storage, codes);
                
                batch.BatchNumber = GetBatchNumber() + 1;
                // if (IsRunning)
                // {
                //     batch.Start();
                // }
                _context.Batch.Add(batch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                
            }
            catch (DbUpdateConcurrencyException e)
            {
                return View("Error", e.Message);
            }
        }

        private int GetBatchNumber()
        {
            var isNull = _context.Batch.Where(e => true).ToList().Count > 0;
            if (isNull)
            {
                return _context.Batch.Max(e => e.BatchNumber);
            }
            return 0;
        }

        public async Task<IActionResult> Start(int Id)
        {
            var batches = await _context.Batch.Include(e => e.Storage).Where(e => true).ToListAsync();
            var batch = batches.FirstOrDefault(e => e.Id == Id);
            if (batch == null)
            {
                return NotFound($"cannot find batch with id {Id}");
            }
            var runningBatches = await _context.Batch.Where(e => e.Id != Id && e.IsRunning).Select(e => e.Id).ToListAsync();
            if (runningBatches != null)
            {
                if (runningBatches.Count > 0)
                {
                    return NotFound($"cannot start other batch, only one batch is allowed to run at a time {string.Join(" ", runningBatches)}!");
                    
                }
                
            }
            batch.Start();
            _context.Entry(batch).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Stop(int Id)
        {
            var batch = await _context.Batch.FindAsync(Id);
            if (batch == null)
            {
                return NotFound($"cannot find batch with id {Id}");
            }
            batch.Stop();
            _context.Entry(batch).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}