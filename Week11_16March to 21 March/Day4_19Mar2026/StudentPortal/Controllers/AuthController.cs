using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;
using StudentPortal.Services;

namespace StudentPortal.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly JwtService _jwt;

		public AuthController(UserManager<ApplicationUser> userManager, JwtService jwt)
		{
			_userManager = userManager;
			_jwt = jwt;
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login(string email, string password)
		{
			var user = await _userManager.FindByEmailAsync(email);

			if (user == null || !await _userManager.CheckPasswordAsync(user, password))
				return Unauthorized("Invalid credentials");

			var token = _jwt.GenerateToken(user.Email);

			return Ok(new { token });
		}
	}
}