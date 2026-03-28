namespace EventBookingAPI.DTOs
{
    public class RegisterDto
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }
    }

    public class LoginDto
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }

    public class AuthResponseDto
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public string Token { get; set; }

        public string UserId { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }
    }
}
