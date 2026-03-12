using Microsoft.EntityFrameworkCore;
using MVCEmp.Models;

namespace MVCEmp.Data
{
    public class EmployeeDbContext:DbContext
    {
		public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
		{
		}
		public DbSet<Employee> employees { get; set; }



	}
}
