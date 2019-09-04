using Microsoft.EntityFrameworkCore;

namespace BookingForm.Models
{
    public class PrintContext : DbContext
    {
        public PrintContext(DbContextOptions<PrintContext> options)
            : base(options)
        {
        }

        public DbSet<BookingForm.Models.Print> Print { get; set; }
        public DbSet<BookingForm.Models.Download> Download { get; set; }
        // public DbSet<Sale> sale { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Download>().HasOne(e => e.Print)
                        .WithMany(e => e.Files)
                        .HasForeignKey(e => e.PrintId)
                        .IsRequired()
                        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
