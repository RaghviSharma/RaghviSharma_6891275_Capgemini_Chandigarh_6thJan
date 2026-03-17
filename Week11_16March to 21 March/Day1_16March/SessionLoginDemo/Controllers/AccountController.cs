using Microsoft.AspNetCore.Mvc;

namespace SessionLoginDemo.Controllers
{
	public class AccountController : Controller
	{
		// GET: Login Page
		public IActionResult Login()
		{
			return View();
		}

		// POST: Login
		[HttpPost]
		public IActionResult Login(string username, string password)
		{
			if (username == "admin" && password == "123")
			{
				// Store username in Session
				HttpContext.Session.SetString("Username", username);

				return RedirectToAction("Dashboard");
			}

			ViewBag.Error = "Invalid Username or Password";
			return View();
		}

		// Dashboard Page
		public IActionResult Dashboard()
		{
			var username = HttpContext.Session.GetString("Username");

			// If not logged in → redirect to Login
			if (string.IsNullOrEmpty(username))
			{
				return RedirectToAction("Login");
			}

			ViewBag.Username = username;
			return View();
		}

		// Logout
		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			return RedirectToAction("Login");
		}
	}
}