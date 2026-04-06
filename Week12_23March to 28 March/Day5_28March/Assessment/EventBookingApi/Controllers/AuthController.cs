using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly AppDbContext _context;

    public AuthController(IConfiguration config, AppDbContext context)
    {
        _config = config;
        _context = context;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterDto register)
    {
        // Validate
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        // Check if username already exists
        if (_context.Users.Any(u => u.Username == register.Username))
            return BadRequest(new { message = "Username already exists" });

        // Check if email already exists
        if (_context.Users.Any(u => u.Email == register.Email))
            return BadRequest(new { message = "Email already registered" });

        // Hash password (simple hashing - for production use bcrypt)
        string passwordHash = BCrypt.Net.BCrypt.HashPassword(register.Password);

        var user = new User
        {
            Username = register.Username,
            Email = register.Email,
            PasswordHash = passwordHash,
            Role = "User"
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        // Log registration
        var log = new UserLog
        {
            UserId = user.Id,
            Action = "Registration",
            Details = $"User registered: {register.Email}"
        };
        _context.UserLogs.Add(log);
        _context.SaveChanges();

        return Ok(new { message = "Registration successful. Please login." });
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDto login)
    {
        string role = "";
        int userId = 0;

        // Check if admin
        if (login.Username == "admin" && login.Password == "123")
        {
            role = "Admin";
        }
        else
        {
            // Check if user exists in database
            var user = _context.Users.FirstOrDefault(u => u.Username == login.Username);

            if (user == null || !BCrypt.Net.BCrypt.Verify(login.Password, user.PasswordHash))
            {
                return Unauthorized(new { message = "Invalid credentials" });
            }

            role = user.Role;
            userId = user.Id;

            // Log login
            var log = new UserLog
            {
                UserId = user.Id,
                Action = "Login",
                Details = $"User logged in at {DateTime.Now}"
            };
            _context.UserLogs.Add(log);
            _context.SaveChanges();
        }

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, login.Username),
            new Claim(ClaimTypes.Role, role),
            new Claim("UserId", userId.ToString())
        };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_config["Jwt:Key"])
        );

        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
        );

        return Ok(new
        {
            token = new JwtSecurityTokenHandler().WriteToken(token),
            role = role,
            username = login.Username,
            userId = userId
        });
    }
}