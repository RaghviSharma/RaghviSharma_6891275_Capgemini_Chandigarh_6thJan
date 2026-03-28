using Microsoft.AspNetCore.Mvc;
using StudentAPI.DTOs;
using StudentAPI.Models;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
	private readonly AppDbContext _context;

	public StudentsController(AppDbContext context)
	{
		_context = context;
	}

	// ✅ GET ALL
	[HttpGet]
	public ActionResult<IEnumerable<StudentReadDTO>> GetStudents()
	{
		var students = _context.Students.ToList();

		var result = students.Select(s => new StudentReadDTO
		{
			Id = s.Id,
			Name = s.Name,
			Email = s.Email
		});

		return Ok(result);
	}

	// ✅ GET BY ID
	[HttpGet("{id}")]
	public ActionResult<StudentReadDTO> GetStudent(int id)
	{
		var student = _context.Students.Find(id);

		if (student == null)
			return NotFound();

		var dto = new StudentReadDTO
		{
			Id = student.Id,
			Name = student.Name,
			Email = student.Email
		};

		return Ok(dto);
	}

	// ✅ CREATE
	[HttpPost]
	public IActionResult CreateStudent(StudentCreateDTO dto)
	{
		var student = new Student
		{
			Name = dto.Name,
			Email = dto.Email,
			Password = dto.Password,
			CreatedAt = DateTime.Now
		};

		_context.Students.Add(student);
		_context.SaveChanges();

		return Ok("Student Created Successfully");
	}

	// ✅ UPDATE
	[HttpPut("{id}")]
	public IActionResult UpdateStudent(int id, StudentUpdateDTO dto)
	{
		var student = _context.Students.Find(id);

		if (student == null)
			return NotFound();

		student.Name = dto.Name;
		student.Email = dto.Email;

		_context.SaveChanges();

		return NoContent();
	}

	// ✅ DELETE
	[HttpDelete("{id}")]
	public IActionResult DeleteStudent(int id)
	{
		var student = _context.Students.Find(id);

		if (student == null)
			return NotFound();

		_context.Students.Remove(student);
		_context.SaveChanges();

		return NoContent();
	}
}