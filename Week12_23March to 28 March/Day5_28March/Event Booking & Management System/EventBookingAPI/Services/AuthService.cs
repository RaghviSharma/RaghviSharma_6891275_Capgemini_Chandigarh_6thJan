using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using EventBookingAPI.Models;

namespace EventBookingAPI.Services
{
    public class AuthService
    {
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // 🔐 REGISTER
        public object Register(User user)
        {
            // Normally you would save user to DB here

            var token = GenerateJwtToken(user);

            return new
            {
                token = token,
                userId = user.Id,
                email = user.Email,
                fullName = user.FullName
            };
        }

        // 🔐 LOGIN
        public object Login(User user)
        {
            // Normally validate user from DB

            var token = GenerateJwtToken(user);

            return new
            {
                token = token,
                userId = user.Id,
                email = user.Email,
                fullName = user.FullName
            };
        }

        // 🔐 JWT GENERATION (FIXED)
        private string GenerateJwtToken(User user)
        {
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["Jwt:Key"])
            );

            var credentials = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256
            );

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim("id", user.Id.ToString()),
                new Claim("name", user.FullName)
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}