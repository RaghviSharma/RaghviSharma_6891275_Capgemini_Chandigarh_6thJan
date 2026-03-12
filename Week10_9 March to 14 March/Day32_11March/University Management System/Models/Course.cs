using System.ComponentModel.DataAnnotations;

namespace University_Management_System.Models
{
	public class Course
	{
		public int CourseId { get; set; }

		[Required]
		public string Title { get; set; }

		public int Credits { get; set; }

		public int InstructorId { get; set; }

		public Instructor? Instructor { get; set; }
	}
}