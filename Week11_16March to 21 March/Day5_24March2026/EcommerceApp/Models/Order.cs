using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace EcommerceApp.Models
{
	public class Order
	{
		public int OrderId { get; set; }

		public DateTime OrderDate { get; set; }

		public int CustomerId { get; set; }
		[ValidateNever]
		public Customer Customer { get; set; }
		[ValidateNever]
		public List<OrderItem> OrderItems { get; set; }
		[ValidateNever]
		public ShippingDetail ShippingDetail { get; set; }
	}
}
