namespace EventBookingAPI.Models
{
    public class AppUser
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}
