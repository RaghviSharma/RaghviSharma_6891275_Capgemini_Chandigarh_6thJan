using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [Required]
    public string Role { get; set; } = "User";

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public List<Booking> Bookings { get; set; } = new();
    public List<UserLog> Logs { get; set; } = new();
}
