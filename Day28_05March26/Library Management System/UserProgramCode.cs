using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Library_Management_System
{
	internal class UserProgramCode
	{
		public interface IBook
		{
			int ID { get; set; }
			string Title { get; set; }
			string Author { get; set; }
			string Category { get; set; }
			int Price { get; set; }
		}

		public interface ILibrarySystem
		{
			void AddBook(IBook book, int quant);
			void RemoveBook(IBook book, int quantity);
			int Calculate();
			List<Tuple<string, int>> CategoryTotalPrice();
			List<Tuple<string, int, int>> BookInfo();
			List<Tuple<string, string, int>> categoryAndAuthorWithCount();
		}

		public class Book : IBook
		{
			public int ID { get; set; }
			public string Title { get; set; }
			public string Author { get; set; }
			public string Category { get; set; }
			public int Price { get; set; }

			public Book() { }

			public Book(int id, string title, string author, string category, int price)
			{
				ID = id;
				Title = title;
				Author = author;
				Category = category;
				Price = price;
			}
		}
		public class LibrarySystem : ILibrarySystem
		{
			Dictionary<IBook, int> variable_books = new Dictionary<IBook, int>();
			public void AddBook(IBook book, int quant)
			{
				variable_books[book] = quant;
			}
			public void RemoveBook(IBook book, int quantity)
			{
				if (variable_books.ContainsKey(book))
				{
					variable_books[book] -= quantity;

					if (variable_books[book] <= 0)
						variable_books.Remove(book);
				}
			}
			public int Calculate()
			{
				int total = 0;

				foreach (var item in variable_books)
				{
					total += item.Key.Price * item.Value;
				}

				return total;
			}

			public List<Tuple<string, int>> CategoryTotalPrice()
			{
				var result = new Dictionary<string, int>();

				foreach (var item in variable_books)
				{
					string category = item.Key.Category;
					int price = item.Key.Price * item.Value;

					if (!result.ContainsKey(category))
						result[category] = 0;

					result[category] += price;
				}
				return result
					.Select(x => new Tuple<string, int>(x.Key, x.Value))
					.ToList();
			}

			public List<Tuple<string, int, int>> BookInfo()
			{
				List<Tuple<string, int, int>> result = new List<Tuple<string, int, int>>();

				foreach (var item in variable_books)
				{
					result.Add(new Tuple<string, int, int>(
						item.Key.Title,
						item.Value,
						item.Key.Price
					));
				}

				return result;
			}

			public List<Tuple<string, string, int>> categoryAndAuthorWithCount()
			{
				var dict = new Dictionary<(string, string), int>();

				foreach (var item in variable_books)
				{
					var key = (item.Key.Category, item.Key.Author);

					if (!dict.ContainsKey(key))
						dict[key] = 0;

					dict[key] += item.Value;
				}

				List<Tuple<string, string, int>> result = new List<Tuple<string, string, int>>();

				foreach (var item in dict)
				{
					result.Add(new Tuple<string, string, int>(
						item.Key.Item1,
						item.Key.Item2,
						item.Value
					));
				}

				return result;
			}
		}
	}
}
