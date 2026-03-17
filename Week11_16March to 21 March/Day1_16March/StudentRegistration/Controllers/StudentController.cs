using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Models;

namespace StudentRegistration.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Register(Student student)
		{
			if (ModelState.IsValid)
			{
				student.Id = new Random().Next(1000);

				TempData["SuccessMessage"] = "Student registered successfully!";

				return RedirectToAction("Details", new { id = student.Id, name = student.Name, age = student.Age });
			}

			return View(student);
		}

		public IActionResult Details(int id, string name, int age)
		{
			ViewBag.Id = id;
			ViewBag.Name = name;
			ViewBag.Age = age;

			return View();
		}
	}
}