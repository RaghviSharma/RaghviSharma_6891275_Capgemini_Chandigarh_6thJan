using EmployeeProjectSystem.Data;
using EmployeeProjectSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmployeeProjectSystem.Controllers
{
	public class EmployeesController : Controller
	{
		private readonly ApplicationDbContext _context;

		public EmployeesController(ApplicationDbContext context)
		{
			_context = context;
		}

		// INDEX
		public IActionResult Index()
		{
			var employees = _context.Employees
				.Include(e => e.Department)
				.Include(e => e.EmployeeProjects)
				.ThenInclude(ep => ep.Project)
				.ToList();

			return View(employees);
		}

		// CREATE
		public IActionResult Create()
		{
			ViewBag.Departments = new SelectList(_context.Departments, "DepartmentId", "Name");
			ViewBag.Projects = _context.Projects.ToList();
			return View();
		}

		[HttpPost]
		public IActionResult Create(Employee employee, int[] projectIds)
		{
			_context.Employees.Add(employee);
			_context.SaveChanges();

			foreach (var pid in projectIds)
			{
				_context.EmployeeProjects.Add(new EmployeeProject
				{
					EmployeeId = employee.EmployeeId,
					ProjectId = pid,
					AssignedDate = DateTime.Now
				});
			}

			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		// EDIT
		public IActionResult Edit(int id)
		{
			var employee = _context.Employees.Find(id);

			ViewBag.Departments = new SelectList(_context.Departments, "DepartmentId", "Name", employee.DepartmentId);
			ViewBag.Projects = _context.Projects.ToList();

			return View(employee);
		}

		[HttpPost]
		public IActionResult Edit(Employee employee)
		{
			_context.Employees.Update(employee);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}

		// DELETE
		public IActionResult Delete(int id)
		{
			var emp = _context.Employees.Find(id);
			return View(emp);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(int id)
		{
			var emp = _context.Employees.Find(id);

			_context.Employees.Remove(emp);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}