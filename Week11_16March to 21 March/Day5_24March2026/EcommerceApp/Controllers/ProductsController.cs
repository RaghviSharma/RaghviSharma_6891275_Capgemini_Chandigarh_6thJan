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

		ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
		return View(product);
	}

	// EDIT PRODUCT
	public IActionResult Edit(int id)
	{
		var product = _context.Products.Find(id);
		if (product == null) return NotFound();
	
		ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", product.CategoryId);
		return View(product);
	}

	[HttpPost]
	public IActionResult Edit(Product product)
	{
		if (!ModelState.IsValid)
		{
			ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", product.CategoryId);
			return View(product);
		}

		_context.Products.Update(product);
		_context.SaveChanges();
		return RedirectToAction("Index");
	}

	// DELETE PRODUCT
	public IActionResult Delete(int id)
	{
		var product = _context.Products.Find(id);
		if (product == null) return NotFound();

		return View(product);
	}

	[HttpPost, ActionName("Delete")]
	public IActionResult DeleteConfirmed(int id)
	{
		var product = _context.Products.Find(id);
		if (product == null) return NotFound();

		_context.Products.Remove(product);
		_context.SaveChanges();
		return RedirectToAction("Index");
	}
}
