using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcommerceApp.Data;
using EcommerceApp.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ProductsController : Controller
{
	private readonly AppDbContext _context;

	public ProductsController(AppDbContext context)
	{
		_context = context;
	}

	// READ + FILTER
	public IActionResult Index(int? categoryId)
	{
		var products = _context.Products
			.Include(p => p.Category)
			.AsQueryable();  

		if (categoryId != null)
		{
			products = products.Where(p => p.CategoryId == categoryId);
		}

		ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");

		return View(products.ToList());
	}

	public IActionResult Create()
	{
		ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
		return View();
	}

	[HttpPost]
	public IActionResult Create(Product product)
	{
		if (ModelState.IsValid)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		// 🔥 MUST ADD THIS
		ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");

		return View(product);
	}
}