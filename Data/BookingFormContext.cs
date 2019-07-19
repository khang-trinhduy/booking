using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using BookingForm.Models;

namespace BookingForm.Models
{
    public class BookingFormContext : IdentityDbContext<Sale, Role, Guid, UserClaim, UserRole, UserLogin,
        RoleClaim, UserToken>
    {
        public BookingFormContext (DbContextOptions<BookingFormContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Sale>(b =>
            {
                // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                    .WithOne(e => e.User)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                // Each User can have many UserLogins
                b.HasMany(e => e.Logins)
                    .WithOne(e => e.User)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                // Each User can have many UserTokens
                b.HasMany(e => e.Tokens)
                    .WithOne(e => e.User)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            builder.Entity<Role>(b =>
            {
                // Each Role can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                // Each Role can have many associated RoleClaims
                b.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();
            });
        }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<Appoinment> appoinment { get; set; }
        public DbSet<Sale> sale { get; set; }
        public DbSet<Logger> Loggers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Grant> Grants { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<BookingForm.Models.Catalog> Catalog { get; set; }
        public DbSet<BookingForm.Models.Details> Details { get; set; }
        public DbSet<BookingForm.Models.Section> Section { get; set; }
        public DbSet<BookingForm.Models.Block> Block { get; set; }
        public DbSet<BookingForm.Models.Floor> Floor { get; set; }
        public DbSet<BookingForm.Models.Apartment> Apartment { get; set; }
        public DbSet<BookingForm.Models.Client> Client { get; set; }
        public DbSet<BookingForm.Models.RCode> RCode { get; set; }
        public DbSet<BookingForm.Models.Reserved> Reserve { get; set; }
        public DbSet<BookingForm.Models.Confirmation> Confirmation { get; set; }
        public DbSet<BookingForm.Models.Invoice> Invoice { get; set; }
        // public DbSet<Stage> Stage { get; set; }
        public DbSet<BookingForm.Models.Batch> Batch { get; set; }
    }

    public class ApplicationContextDbFactory : IDesignTimeDbContextFactory<BookingFormContext>
    {
        BookingFormContext IDesignTimeDbContextFactory<BookingFormContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookingFormContext>();
            optionsBuilder.UseSqlServer<BookingFormContext>("Server=192.168.9.5;Database=annhome.booking;user id=khang; password=password");
            //Trusted_Connection = True; MultipleActiveResultSets = true
            return new BookingFormContext(optionsBuilder.Options);
        }
    }
}
