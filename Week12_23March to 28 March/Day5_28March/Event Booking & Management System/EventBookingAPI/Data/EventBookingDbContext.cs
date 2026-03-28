using Microsoft.EntityFrameworkCore;
using EventBookingAPI.Models;

namespace EventBookingAPI.Data
{
    public class EventBookingDbContext : DbContext
    {
        public EventBookingDbContext(DbContextOptions<EventBookingDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Event entity
            modelBuilder.Entity<Event>()
                .HasMany(e => e.Bookings)
                .WithOne(b => b.Event)
                .HasForeignKey(b => b.EventId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure Booking entity
            modelBuilder.Entity<Booking>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<Booking>()
                .Property(b => b.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (BookingStatus)Enum.Parse(typeof(BookingStatus), v));

            // Seed sample data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed events
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Title = "Tech Conference 2026",
                    Description = "Annual technology conference featuring industry leaders",
                    Date = DateTime.Now.AddDays(30),
                    Location = "San Francisco, CA",
                    AvailableSeats = 500,
                    BookedSeats = 0,
                    Price = 299.99m,
                    CreatedAt = DateTime.Now
                },
                new Event
                {
                    Id = 2,
                    Title = "Web Development Workshop",
                    Description = "Hands-on workshop for modern web development",
                    Date = DateTime.Now.AddDays(15),
                    Location = "New York, NY",
                    AvailableSeats = 50,
                    BookedSeats = 0,
                    Price = 149.99m,
                    CreatedAt = DateTime.Now
                },
                new Event
                {
                    Id = 3,
                    Title = "Cloud Computing Seminar",
                    Description = "Learn about cloud infrastructure and deployment",
                    Date = DateTime.Now.AddDays(45),
                    Location = "Austin, TX",
                    AvailableSeats = 100,
                    BookedSeats = 0,
                    Price = 199.99m,
                    CreatedAt = DateTime.Now
                },
                new Event
                {
                    Id = 4,
                    Title = "AI & Machine Learning Summit",
                    Description = "Explore the latest trends in AI and ML",
                    Date = DateTime.Now.AddDays(60),
                    Location = "Seattle, WA",
                    AvailableSeats = 200,
                    BookedSeats = 0,
                    Price = 349.99m,
                    CreatedAt = DateTime.Now
                }
            );
        }
    }
}
