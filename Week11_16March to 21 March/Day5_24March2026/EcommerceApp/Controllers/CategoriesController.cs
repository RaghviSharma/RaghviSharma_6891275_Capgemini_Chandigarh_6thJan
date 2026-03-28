using Microsoft.AspNetCore.Mvc;
using EcommerceApp.Data;
using EcommerceApp.Models;

public class CategoriesController : Controller
{
	private readonly AppDbContext _context;

	public CategoriesController(AppDbContext context)
	{
		_context = context;
	}

	public IActionResult Index()
	{
		return View(_context.Categories.ToList());
	}

	public IActionResult Create()
	{
		return View();
	}

	[HttpPost]
	public IActionResult Create(Category category)
	{
		if (ModelState.IsValid)
		{
			_context.Categories.Add(category);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		return View(category);
	}
}