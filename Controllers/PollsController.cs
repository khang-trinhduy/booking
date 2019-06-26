using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookingForm.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace BookingForm.Controllers
{
    public class PollsController : Controller
    {
        private readonly BookingFormContext _context;
        public PollsController(BookingFormContext context)
        {
            _context = context;
        }
        public async void Remove()
        {
            try
            {
                var codes = await _context.RCode.Where(e => true).ToListAsync();
                foreach (var item in codes)
                {
                    item.IsUsed = true;
                    _context.Entry(item).State = EntityState.Modified;
                }
                await _context.SaveChangesAsync();
                
            }
            catch (System.Exception e)
            {
                
                throw new Exception(e.Message);
            }

        }
    }
}