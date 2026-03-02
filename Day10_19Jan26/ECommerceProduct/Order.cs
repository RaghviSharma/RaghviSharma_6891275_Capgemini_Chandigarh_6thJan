using System;
using ECommerceProduct;

namespace ECommerceProduct
{
	internal class Order
	{
		public void PlaceOrder(Cart cart)
		{
			Console.WriteLine("\nOrder Placed Successfully!");
			cart.View();
		}
	}
}
