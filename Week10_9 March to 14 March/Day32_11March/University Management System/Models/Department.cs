using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System.Models
{
	public class Department
	{
		public int DepartmentId { get; set; }

		[Required]
		public string Name { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal Budget { get; set; }

		public ICollection<Instructor>? Instructors { get; set; }
	}
}