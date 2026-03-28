using System.ComponentModel.DataAnnotations;

namespace EventBookingAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Range(1, 100, ErrorMessage = "Seats booked must be between 1 and 100")]
        public int SeatsBooked { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime BookedAt { get; set; } = DateTime.Now;

        public BookingStatus Status { get; set; } = BookingStatus.Confirmed;

        // Navigation properties
        public Event Event { get; set; }
    }

    public enum BookingStatus
    {
        Confirmed = 1,
        Cancelled = 2,
        Pending = 3
    }
}
