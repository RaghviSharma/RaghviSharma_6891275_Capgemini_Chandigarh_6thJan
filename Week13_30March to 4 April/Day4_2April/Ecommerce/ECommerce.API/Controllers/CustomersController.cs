using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/customers")]
public class CustomersController : ControllerBase
{
    private readonly AppDbContext _context;

    public CustomersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetCustomers()
    {
        var users = await _context.Users
            .Include(u => u.Profile)
            .ToListAsync();

        return Ok(users.Select(u => new
        {
            u.Id,
            u.Name,
            Profile = new
            {
                u.Profile?.Address
            }
        }));
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomer([FromBody] User user)
    {
        if (string.IsNullOrWhiteSpace(user.Name))
            return BadRequest("Customer name is required.");

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCustomers), new { id = user.Id }, user);
    }
}

