using BookingForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BookingForm.Controllers
{
    public class ProductsController : Controller
    {
        private readonly BookingFormContext _context;
        public ProductsController(BookingFormContext context)
        {
            _context = context;
        }
        
        
    }
}