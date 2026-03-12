using System.ComponentModel.DataAnnotations;

namespace University_Management_System.Models
{
	public class Instructor
	{
		public int InstructorId { get; set; }

		[Required]
		public string Name { get; set; }

		public int DepartmentId { get; set; }

		public Department? Department { get; set; }
	}
}