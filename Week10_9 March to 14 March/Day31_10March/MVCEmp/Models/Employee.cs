using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEmp.Models
{
    [Table("tbEmployee")]
    public class Employee
    {
        [Key]
        public int Empid { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

    }
}
