using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace EcommerceApp.Models
{
	public class Product
	{
		public int ProductId { get; set; }

		[Required]
		public string Name { get; set; }

		[Range(1, 100000)]
		public decimal Price { get; set; }

		public int CategoryId { get; set; }
		[ValidateNever]
		public Category Category { get; set; }
		[ValidateNever]
		public List<OrderItem> OrderItems { get; set; }
	}
}
