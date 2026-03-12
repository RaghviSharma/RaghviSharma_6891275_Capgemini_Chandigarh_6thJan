using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;

public class StudentsController : Controller
{
	private readonly IRequestLogService _logService;

	public StudentsController(IRequestLogService logService)
	{
		_logService = logService;
	}

	public IActionResult Index()
	{
		var students = new List<Student>
		{
			new Student { Id = 1, Name = "Raghvi" },
			new Student { Id = 2, Name = "Riya" }
		};

		ViewBag.Students = students;
		ViewBag.Logs = _logService.GetLogs();

		return View();
	}
}