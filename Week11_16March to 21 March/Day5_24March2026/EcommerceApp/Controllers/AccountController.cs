using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
	// LOGIN PAGE
	public IActionResult Login()
	{
		return View();
	}

	// LOGIN POST
	[HttpPost]
	public IActionResult Login(string username, string password)
	{
		if (username == "admin" && password == "admin123")
		{
			HttpContext.Session.SetString("Admin", "true");
			return RedirectToAction("Dashboard", "Admin");
		}

		ViewBag.Error = "Invalid Username or Password";
		return View();
	}

	// LOGOUT
	public IActionResult Logout()
	{
		HttpContext.Session.Clear();
		return RedirectToAction("Login");
	}
}