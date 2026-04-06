using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Booking
{
    public int Id { get; set; }

    public int EventId { get; set; }
    public Event Event { get; set; }

    public int? UserId { get; set; }
    public User User { get; set; }

    public string UsernameDisplay { get; set; } // For backward compatibility

    [Range(1, 10)]
    public int SeatsBooked { get; set; }

    public DateTime BookedAt { get; set; } = DateTime.Now;
}