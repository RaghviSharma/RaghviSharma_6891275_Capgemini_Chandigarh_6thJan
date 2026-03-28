using Microsoft.AspNetCore.Mvc;
using EcommerceApp.Data;
using EcommerceApp.Models;

public class CustomersController : Controller
{
	private readonly AppDbContext _context;

	public CustomersController(AppDbContext context)
	{
		_context = context;
	}

	// READ
	public IActionResult Index()
	{
		var customers = _context.Customers.ToList();
		return View(customers);
	}

	// CREATE (GET)
	public IActionResult Create()
	{
		return View();
	}

	// CREATE (POST)
	[HttpPost]
	public IActionResult Create(Customer customer)
	{
		if (ModelState.IsValid)
		{
			_context.Customers.Add(customer);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		return View(customer);
	}

	// DELETE
	public IActionResult Delete(int id)
	{
		var customer = _context.Customers.Find(id);
		if (customer != null)
		{
			_context.Customers.Remove(customer);
			_context.SaveChanges();
		}
		return RedirectToAction("Index");
	}
}