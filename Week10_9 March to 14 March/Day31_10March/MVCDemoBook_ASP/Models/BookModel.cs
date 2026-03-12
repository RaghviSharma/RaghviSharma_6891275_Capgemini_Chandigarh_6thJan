using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MVCDemoBook_ASP.Models
{
	[Table("tblBook")]

	public class BookModel
    {
		[Key]
		public int BookId { get; set; }
		public string BookName { get; set; }
		public string Author { get; set; }
		public int Price { get; set; }
		public int Pages { get; set; }      // new column

		public string Description { get; set; }   // new column
	}
}
