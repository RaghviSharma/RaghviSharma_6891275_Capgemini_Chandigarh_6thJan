namespace University_Management_System.Models
{
	using System.ComponentModel.DataAnnotations;

	public class Student
	{
		public int StudentId { get; set; }

		[Required]
		public string FullName { get; set; }

		[Required]
		public string Email { get; set; }

		public DateTime EnrollmentDate { get; set; }
	}
}
