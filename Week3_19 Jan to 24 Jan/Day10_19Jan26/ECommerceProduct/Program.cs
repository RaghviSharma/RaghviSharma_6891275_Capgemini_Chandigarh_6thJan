using System;
using System.Collections.Generic;
using ECommerceProduct;

namespace ECommerceProduct
{
	internal class Program
	{
		static int pid = 1;
		static List<Product> products = new List<Product>();
		static Cart cart = new Cart();

		static void Main()
		{
			while (true)
			{
				Console.WriteLine("\n1. Add Product");
				Console.WriteLine("2. View Products");
				Console.WriteLine("3. Add to Cart");
				Console.WriteLine("4. View Cart");
				Console.WriteLine("5. Place Order");
				Console.WriteLine("6. Exit");

				int ch = Convert.ToInt32(Console.ReadLine());

				switch (ch)
				{
					case 1:
						AddProduct();
						break;

					case 2:
						ViewProducts();
						break;

					case 3:
						AddToCart();
						break;

					case 4:
						cart.View();
						break;

					case 5:
						Order o = new Order();
						o.PlaceOrder(cart);
						break;

					case 6:
						return;
				}
			}
		}

		static void AddProduct()
		{
			Console.WriteLine("1.Electronics  2.Clothing  3.Books");
			int type = Convert.ToInt32(Console.ReadLine());

			Product p;

			if (type == 1) p = new Electronics();
			else if (type == 2) p = new Clothing();
			else p = new Books();

			p.ProductId = pid++;

			Console.Write("Enter Name: ");
			p.Name = Console.ReadLine();

			Console.Write("Enter Price: ");
			p.Price = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter Stock: ");
			p.Stock = Convert.ToInt32(Console.ReadLine());

			products.Add(p);
		}

		static void ViewProducts()
		{
			foreach (var p in products)
				p.Display();
		}

		static void AddToCart()
		{
			Console.Write("Enter Product Id: ");
			int id = Convert.ToInt32(Console.ReadLine());

			foreach (var p in products)
				if (p.ProductId == id)
					cart.Add(p);
		}
	}
}
