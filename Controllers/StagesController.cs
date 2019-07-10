using System.Linq;
using System.Threading.Tasks;
using BookingForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingForm.Controllers
{
    public class StagesController : Controller
    {
        private readonly BookingFormContext _context;
        public StagesController(BookingFormContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var stages = _context.Stage.Where(e => true).ToList();
            return View(stages);
        }
        public async Task<IActionResult> Create()
        {
            var apartments = await _context.Apartment.Where(e => _context.Confirmation.FirstOrDefault(c => c.LocalCode == e.LocalCode) == null).ToListAsync();
            var codes = await _context.RCode.Where(e => !e.IsUsed).ToListAsync();
            return View(new StageCreateModel {Apartment = apartments, Code = codes});
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Apartment, Code, IsRunning")]StageCreateModel item)
        {
            if (item == null)
            {
                return View("Error", $"cannot add a null stage");
            }
            try
            {
                var stage = new Stage(item.Apartment, item.Code);
                stage.StageNumber = await _context.Stage.MaxAsync(e => e.StageNumber) + 1;
                _context.Stage.Add(stage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                
            }
            catch (DbUpdateConcurrencyException e)
            {
                return View("Error", e.Message);
            }
        }
        public async Task<IActionResult> Start(int Id)
        {
            var stage = await _context.Stage.FindAsync(Id);
            if (stage == null)
            {
                return NotFound($"cannot find stage with id {Id}");
            }
            var runningStages = await _context.Stage.Where(e => e.Id != Id && e.IsRunning).Select(e => e.Id).ToListAsync();
            if (runningStages != null)
            {
                ViewBag.msg = $"cannot start other stage, only one stage is allowed to run at a time {string.Join(" ", runningStages)}!";
                return View(nameof(Index));
            }
            stage.Start();
            _context.Entry(stage).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return View(nameof(Index));
        }
        public async Task<IActionResult> Stop(int Id)
        {
            var stage = await _context.Stage.FindAsync(Id);
            if (stage == null)
            {
                return NotFound($"cannot find stage with id {Id}");
            }
            stage.Stop();
            _context.Entry(stage).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}