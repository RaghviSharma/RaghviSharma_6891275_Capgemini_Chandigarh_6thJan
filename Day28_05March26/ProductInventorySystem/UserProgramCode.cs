using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInventorySystem
{
    internal class UserProgramCode
    {
		public interface IProduct
		{
			string Name { get; set; }
			 string Category { get; set; }
			int Price { get; set; }
			int Stock { get; set; }
		}
		public interface IInventory
		{

		}
		public class Product : IProduct
		{
			public string Name { get; set; }
			public string Category {  get; set; }
			public int Price {  get; set; }
			public int Stock {  get; set; }
			public Product() { }
			public Product(string name, string category, int price, int stock)
			{
				Name = name;
				Category = category;
				Price = price;
				Stock = stock;
			}
		}
		public class Inventory : IInventory
		{
			private List<IProduct> field_products = new List<IProduct>();

			public void AddProduct(IProduct product)
			{
				field_products.Add(product);
			}
			public void RemoveProduct(IProduct product) 
			{
				field_products.Remove(product); 
			}
			public int Calculate_TotalValue()
			{
				int total = 0;
				foreach (var item in field_products)
				{
					total += item.Price * item.Stock;
					
				}
				return total;
			}
			public List<IProduct> GetProductsByCategory(string category)
			{
				return field_products.Where(c=>c.Category==category).ToList();
			}
			public List<Tuple<string,int>> GetProductsByCategoryWithCount()
			{
				Dictionary<string,int> dt=new Dictionary<string,int>();
				foreach (var item in field_products)
				{
					string cat = item.Category;
					if (!dt.ContainsKey(cat))
					{
						dt[cat] = 0;
					}
					dt[cat]++;
				}
				List<Tuple<string,int>> res=new List<Tuple<string,int>>();
				foreach (var item in dt)
				{
					res.Add(new Tuple<string, int>(item.Key, item.Value));
				}
				return res;

			}
			public List<IProduct> SearchProductsByName(string name)
			{
				return field_products.Where(c => c.Name == name).ToList();
			}
			public List<(string, List<IProduct>)> GetAllProductsByCategory()
			{
				return field_products
					.GroupBy(p => p.Category)
					.Select(g => (g.Key, g.ToList()))
					.ToList();
			}
		}
	}
}
