using Microsoft.AspNetCore.Mvc;
using ProductManagement.Filters;
using System.Collections.Generic;

namespace ProductManagement.Controllers
{
	[ServiceFilter(typeof(LogActionFilter))]
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			// Testing exception handling
			throw new Exception("Test Exception");

			var products = new List<string>
			{
				"Laptop",
				"Mobile",
				"Tablet"
			};

			return View(products);
		}
	}
}