namespace EventBooking.RazorPages.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int AvailableSeats { get; set; }
        public int BookedSeats { get; set; }
        public int RemainingSeats => AvailableSeats - BookedSeats;
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class BookingViewModel
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string UserId { get; set; }
        public int SeatsBooked { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime BookedAt { get; set; }
        public string Status { get; set; }
        public EventViewModel Event { get; set; }
    }

    public class AuthViewModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
    }

    public class CurrentUserViewModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
    }
}
