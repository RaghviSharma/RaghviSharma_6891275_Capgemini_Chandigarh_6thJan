using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/categories")]
public class CategoriesController : ControllerBase
{
    private readonly AppDbContext _context;

    public CategoriesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetCategories()
    {
        var categories = await _context.Categories
            .Include(c => c.ProductCategories)
            .ThenInclude(pc => pc.Product)
            .ToListAsync();

        return Ok(categories.Select(c => new
        {
            c.Id,
            c.Name,
            Products = c.ProductCategories?.Select(pc => pc.Product?.Name).Where(n => n != null).ToList() ?? new List<string>()
        }));
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] Category category)
    {
        if (string.IsNullOrWhiteSpace(category.Name))
            return BadRequest("Category name is required.");

        _context.Categories.Add(category);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCategories), new { id = category.Id }, category);
    }
}
