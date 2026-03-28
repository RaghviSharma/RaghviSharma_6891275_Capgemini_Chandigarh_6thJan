using Microsoft.AspNetCore.Mvc;
using EcommerceApp.Data;
using Microsoft.EntityFrameworkCore;

public class AdminController : Controller
{
	private readonly AppDbContext _context;

	public AdminController(AppDbContext context)
	{
		_context = context;
	}

	public IActionResult Dashboard()
	{
		// 🔥 Top 5 Selling Products
		if (HttpContext.Session.GetString("Admin") != "true")
		{
			return RedirectToAction("Login", "Account");
		}
		var topProducts = _context.OrderItems
			.Include(o => o.Product)
			.GroupBy(o => new { o.ProductId, o.Product.Name })
			.Select(g => new
			{
				ProductId = g.Key.ProductId,
				ProductName = g.Key.Name,
				TotalSold = g.Sum(x => x.Quantity)
			})
			.OrderByDescending(x => x.TotalSold)
			.Take(5)
			.ToList();

		var pendingOrders = _context.ShippingDetails
			.Include(s => s.Order)
			.ThenInclude(o => o.Customer)
			.Where(s => s.Status == "Pending")
			.Select(s => new
			{
				OrderId = s.OrderId,
				CustomerName = s.Order.Customer.Name,
				Status = s.Status
			})
			.ToList();

		ViewBag.TopProducts = topProducts;
		ViewBag.PendingOrders = pendingOrders;

		return View();
	}
}