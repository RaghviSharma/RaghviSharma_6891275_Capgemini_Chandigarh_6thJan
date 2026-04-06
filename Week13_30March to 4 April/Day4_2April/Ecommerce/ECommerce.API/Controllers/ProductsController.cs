using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _context.Products
            .Include(p => p.ProductCategories)
            .ThenInclude(pc => pc.Category)
            .ToListAsync();

        var result = products.Select(p => new
        {
            p.Id,
            p.Name,
            Categories = p.ProductCategories?.Select(pc => pc.Category?.Name).Where(n => n != null).ToList() ?? new List<string>()
        });

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] Product product)
    {
        if (string.IsNullOrWhiteSpace(product.Name))
            return BadRequest("Product name is required.");

        _context.Products.Add(product);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
    }
}
