using System;

namespace ECommerceProduct
{
	internal class Product
	{
		public int ProductId { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public int Stock { get; set; }

		public virtual string Category()
		{
			return "General";
		}

		public virtual void Display()
		{
			Console.WriteLine(" ProductId  | ProductName  | ProductPrice  | Stock  |  Category");
			Console.WriteLine($"   {ProductId}               {Name}            {Price}          {Stock}      {Category()}");
		}
	}
}
