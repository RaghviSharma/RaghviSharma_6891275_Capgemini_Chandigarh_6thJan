using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EcommerceApp.Data;
using EcommerceApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

public class OrdersController : Controller
{
	private readonly AppDbContext _context;

	public OrdersController(AppDbContext context)
	{
		_context = context;
	}

	// VIEW ORDERS
	public IActionResult Index()
	{
		var orders = _context.Orders
			.Include(o => o.Customer)
			.Include(o => o.OrderItems)
			.ThenInclude(oi => oi.Product)
			.Include(o => o.ShippingDetail)
			.ToList();

		return View(orders);
	}

	// CREATE ORDER (GET)
	public IActionResult Create()
	{
		ViewBag.Customers = new SelectList(_context.Customers, "CustomerId", "Name");
		ViewBag.Products = new SelectList(_context.Products, "ProductId", "Name");

		return View();
	}

	// CREATE ORDER (POST)
	[HttpPost]
	public IActionResult Create(Order order, int productId, int quantity, string address)
	{
		if (ModelState.IsValid)
		{
			order.OrderDate = DateTime.Now;
			_context.Orders.Add(order);
			_context.SaveChanges();

			// OrderItem
			var orderItem = new OrderItem
			{
				OrderId = order.OrderId,
				ProductId = productId,
				Quantity = quantity
			};

			_context.OrderItems.Add(orderItem);

			// Shipping
			var shipping = new ShippingDetail
			{
				OrderId = order.OrderId,
				Address = address,
				Status = "Pending"
			};

			_context.ShippingDetails.Add(shipping);

			_context.SaveChanges();

			return RedirectToAction("Index");
		}

		return View(order);
	}
}