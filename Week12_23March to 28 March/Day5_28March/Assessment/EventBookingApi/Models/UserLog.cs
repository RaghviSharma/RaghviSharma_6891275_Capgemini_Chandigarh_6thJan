using System.ComponentModel.DataAnnotations;

public class UserLog
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    [Required]
    public string Action { get; set; } // "Login", "Booking", "CancelBooking", etc.

    public string Details { get; set; }

    public DateTime Timestamp { get; set; } = DateTime.Now;
}
