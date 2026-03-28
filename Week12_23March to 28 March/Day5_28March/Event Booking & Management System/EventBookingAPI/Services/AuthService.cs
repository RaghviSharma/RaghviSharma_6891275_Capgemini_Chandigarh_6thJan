using EventBookingAPI.Data;
using EventBookingAPI.DTOs;
using EventBookingAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EventBookingAPI.Services
{
    public interface IAuthService
    {
        Task<AuthResponseDto> RegisterAsync(RegisterDto registerDto);
        Task<AuthResponseDto> LoginAsync(LoginDto loginDto);
        Task<AppUser> GetUserByEmailAsync(string email);
    }

    public class AuthService : IAuthService
    {
        private readonly EventBookingDbContext _context;
        private readonly ITokenService _tokenService;
        private readonly ILogger<AuthService> _logger;

        public AuthService(EventBookingDbContext context, ITokenService tokenService, ILogger<AuthService> logger)
        {
            _context = context;
            _tokenService = tokenService;
            _logger = logger;
        }

        public async Task<AuthResponseDto> RegisterAsync(RegisterDto registerDto)
        {
            try
            {
                // Check if user already exists
                var existingUser = _context.Users.FirstOrDefault(u => u.Email == registerDto.Email);
                if (existingUser != null)
                {
                    return new AuthResponseDto
                    {
                        Success = false,
                        Message = "User already exists with this email"
                    };
                }

                var user = new AppUser
                {
                    Email = registerDto.Email,
                    FullName = registerDto.FullName,
                    PhoneNumber = registerDto.PhoneNumber,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(registerDto.Password)
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                var token = _tokenService.GenerateToken(user);

                return new AuthResponseDto
                {
                    Success = true,
                    Message = "Registration successful",
                    Token = token,
                    UserId = user.Id,
                    Email = user.Email,
                    FullName = user.FullName
                };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Registration error: {ex.Message}");
                return new AuthResponseDto
                {
                    Success = false,
                    Message = "Registration failed"
                };
            }
        }

        public async Task<AuthResponseDto> LoginAsync(LoginDto loginDto)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Email == loginDto.Email);
                if (user == null || !BCrypt.Net.BCrypt.Verify(loginDto.Password, user.PasswordHash))
                {
                    return new AuthResponseDto
                    {
                        Success = false,
                        Message = "Invalid email or password"
                    };
                }

                var token = _tokenService.GenerateToken(user);

                return new AuthResponseDto
                {
                    Success = true,
                    Message = "Login successful",
                    Token = token,
                    UserId = user.Id,
                    Email = user.Email,
                    FullName = user.FullName
                };
            }
            catch (Exception ex)
            {
                _logger.LogError($"Login error: {ex.Message}");
                return new AuthResponseDto
                {
                    Success = false,
                    Message = "Login failed"
                };
            }
        }

        public async Task<AppUser> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
