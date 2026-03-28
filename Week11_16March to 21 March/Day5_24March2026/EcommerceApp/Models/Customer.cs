using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
	using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

    public class Customer
	{
		public int CustomerId { get; set; }

		[Required]
		public string Name { get; set; }

		[EmailAddress]
		public string Email { get; set; }
		[ValidateNever]
		public List<Order> Orders { get; set; }
	}
}
