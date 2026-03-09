using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_Commerce_Category_Analytics
{
	internal class UserProgramCode
	{
		public interface ICategory
		{
			int ID { get; set; }
			string Name { get; set; }
			List<IProduct> Products { get; set; }
			void AddProduct(IProduct product);
		}

		public interface IProduct
		{
			int ID { get; set; }
			string Name { get; set; }
			decimal Price { get; set; }
		}

		public interface ICompany
		{
			void AddCategory(ICategory category);
			string GetTopCategoryNameByProductCount();
			List<IProduct> GetProductsBelongsToMultipleCategory();
			(string categoryName, decimal totalValue) GetTopCategoryBySumOfProductPrices();
			List<(ICategory category, decimal totalValue)> GetCategoriesWithSumOfTheProductPrices();
		}

		class Category : ICategory
		{
			public int ID { get; set; }
			public string Name { get; set; }
			public List<IProduct> Products { get; set; }

			public Category(int id, string name)
			{
				ID = id;
				Name = name;
				Products = new List<IProduct>();
			}

			public void AddProduct(IProduct product)
			{
				Products.Add(product);
			}
		}

		class Product : IProduct
		{
			public int ID { get; set; }
			public string Name { get; set; }
			public decimal Price { get; set; }

			public Product(int id, string name, decimal price)
			{
				ID = id;
				Name = name;
				Price = price;
			}
		}

		class Company : ICompany
		{
			public int ID { get; set; }
			public string Name { get; set; }
			public List<ICategory> Categories { get; set; }

			public Company(int id, string name)
			{
				ID = id;
				Name = name;
				Categories = new List<ICategory>();
			}

			public void AddCategory(ICategory category)
			{
				Categories.Add(category);
			}

			public string GetTopCategoryNameByProductCount()
			{
				return Categories
					.OrderByDescending(c => c.Products.Count)
					.First()
					.Name;
			}

			public List<IProduct> GetProductsBelongsToMultipleCategory()
			{
				return Categories
					.SelectMany(c => c.Products)
					.GroupBy(p => p.ID)
					.Where(g => g.Count() > 1)
					.Select(g => g.First())
					.ToList();
			}

			public (string categoryName, decimal totalValue) GetTopCategoryBySumOfProductPrices()
			{
				var result = Categories
					.Select(c => new
					{
						Name = c.Name,
						Sum = c.Products.Sum(p => p.Price)
					})
					.OrderByDescending(x => x.Sum)
					.First();

				return (result.Name, result.Sum);
			}

			public List<(ICategory category, decimal totalValue)> GetCategoriesWithSumOfTheProductPrices()
			{
				return Categories
					.Select(c => (c, c.Products.Sum(p => p.Price)))
					.ToList();
			}
		}
	}
}