using EventBookingAPI.Models;

namespace EventBookingAPI.DTOs
{
    public class BookingDto
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public string UserId { get; set; }

        public int SeatsBooked { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime BookedAt { get; set; }

        public string Status { get; set; }

        public EventDto Event { get; set; }
    }

    public class CreateBookingDto
    {
        public int EventId { get; set; }

        public int SeatsBooked { get; set; }
    }

    public class CancelBookingDto
    {
        public int BookingId { get; set; }

        public string Reason { get; set; }
    }
}
