using BookingForm.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookingForm.Migrations
{
    public class ApplicationContextDbFactory : IDesignTimeDbContextFactory<BookingFormContext>
    {
        BookingFormContext IDesignTimeDbContextFactory<BookingFormContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookingFormContext>();
            optionsBuilder.UseSqlServer<BookingFormContext>("server=khang-pc\\sqlexpress;Database=annhome.booking;trusted_connection=true");
            //192.168.9.5;Database=annhome.booking;user id=khang; password=password
            //khang-pc\\sqlexpress;database=annhome.booking;trusted_connection=true
            return new BookingFormContext(optionsBuilder.Options);
        }

    }
}