namespace EventBookingAPI.DTOs
{
    public class EventDto
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

    public class CreateEventDto
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public int AvailableSeats { get; set; }

        public decimal Price { get; set; }
    }

    public class UpdateEventDto
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public int AvailableSeats { get; set; }

        public decimal Price { get; set; }
    }
}
