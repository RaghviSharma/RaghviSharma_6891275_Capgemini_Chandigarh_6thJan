using System;
using System.Collections.Generic;
using ECommerceProduct;

namespace ECommerceProduct
{
	internal class Cart
	{
		public List<Product> items = new List<Product>();

		public void Add(Product p)
		{
			if (p.Stock > 0)
			{
				items.Add(p);
				p.Stock--;
				Console.WriteLine("Added to cart.");
			}
			else
				Console.WriteLine("Out of stock.");
		}

		public void View()
		{
			foreach (var i in items)
				i.Display();
		}
	}
}
