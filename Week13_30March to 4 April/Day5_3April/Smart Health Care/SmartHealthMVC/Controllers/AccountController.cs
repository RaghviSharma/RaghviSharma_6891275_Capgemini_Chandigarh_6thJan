using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    // GET: Login Page
    public IActionResult Login()
    {
        return View();
    }

    // POST: Login
    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        // Dummy login (you can connect DB later)
        if (email == "admin@gmail.com" && password == "1234")
        {
            return RedirectToAction("Index", "Home");
        }

        ViewBag.Error = "Invalid Login!";
        return View();
    }

    public IActionResult Logout()
    {
        return RedirectToAction("Login");
    }
}