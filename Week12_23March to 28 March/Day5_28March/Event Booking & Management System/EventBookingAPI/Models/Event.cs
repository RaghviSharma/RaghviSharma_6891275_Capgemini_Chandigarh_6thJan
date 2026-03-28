using System.ComponentModel.DataAnnotations;
using EventBookingAPI.Validators;

namespace EventBookingAPI.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Event title is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 100 characters")]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Event date is required")]
        [FutureDate(ErrorMessage = "Event date must be in the future")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(200)]
        public string Location { get; set; }

        [Range(1, 10000, ErrorMessage = "Available seats must be between 1 and 10000")]
        public int AvailableSeats { get; set; }

        [Range(0, 10000, ErrorMessage = "Booked seats cannot be negative")]
        public int BookedSeats { get; set; } = 0;

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation property
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
