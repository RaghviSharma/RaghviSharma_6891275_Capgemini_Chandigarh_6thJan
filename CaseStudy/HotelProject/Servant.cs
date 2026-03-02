using System;
using System.Collections.Generic;

namespace HotelProject
{
	public enum ServantRole
	{
		Chef,
		Cleaner,
		Attendant,
		Security
	}

	public class Servant
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public ServantRole Role { get; set; }

		public override string ToString()
		{
			return $"Name: {Name}, Age: {Age}, Role: {Role}";
		}
	}

	public class ServantManager
	{
		private List<Servant> servants = new List<Servant>();

		public void AddServant()
		{
			try
			{
				Console.Write("Enter servant name: ");
				string name = Console.ReadLine();

				Console.Write("Enter servant age: ");
				int age = Convert.ToInt32(Console.ReadLine());

				Console.Write("Enter servant role (Chef/Cleaner/Attendant/Security): ");
				string roleInput = Console.ReadLine();
				ServantRole role = (ServantRole)Enum.Parse(typeof(ServantRole), roleInput, true);

				servants.Add(new Servant { Name = name, Age = age, Role = role });
				Console.WriteLine("Servant added successfully!");
			}
			catch
			{
				Console.WriteLine("Invalid input! Please try again.");
			}
		}

		public void DisplayServants()
		{
			Console.WriteLine("\n--- Servants in the Hotel ---");
			foreach (var s in servants)
			{
				Console.WriteLine(s);
			}
		}

		public void CountServants()
		{
			Console.WriteLine($"\nTotal servants: {servants.Count}");
		}

		public void ClearServants()
		{
			servants.Clear();
			Console.WriteLine("All servants removed!");
		}
	}
}
