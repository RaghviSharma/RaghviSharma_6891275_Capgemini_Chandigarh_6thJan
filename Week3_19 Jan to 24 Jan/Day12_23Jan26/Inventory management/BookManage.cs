using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Inventory_management
{
    internal class BookManage
    {
		public static Dictionary<int , (int price,string name,int count)> dict= new Dictionary<int,(int,string,int)>();
        public void store()
        {
            Console.WriteLine("Enter the number of books u want to add:");
            int n=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter the id num:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name of the book:");
                string name=Console.ReadLine();

                Console.WriteLine("Enter the price of the book:");
                int price=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the quantity of that book:");
                int quantity=Convert.ToInt32(Console.ReadLine());

                dict.Add(id, (price, name, quantity));
            }
        }
        public void Display()
        {

            Console.WriteLine("\n*******List of books available in book store*********\n");
            Console.WriteLine(" Book id  | Book Price  |  Book name  |  Quantity");
            foreach(var (key,value) in dict)
            {
                Console.WriteLine($" {key}      {value.Item1}      {value.Item2}     {value.Item3}  ");

            }
        }
		public void cheaper()
		{
			Console.WriteLine("Enter the target price: ");
			int target = Convert.ToInt32(Console.ReadLine());

			var list = from item in dict
					   where item.Value.price < target
					   select item.Value.name;

			foreach (var ch in list)
			{
				Console.WriteLine(ch);
			}
		}
		public void sale()
        {
            Console.WriteLine("Enter the percentage to increase price:");
            int n = Convert.ToInt32(Console.ReadLine());
			foreach (var (key, value) in dict)
			{
                int cost = value.price;
                cost = cost + (cost * n) / 100;
			}

		}
		public void outOfStock()
		{
			List<int> removeKeys = new List<int>();

			foreach (var (key, value) in dict)
			{
				if (value.count < 1)
				{
					removeKeys.Add(key);
				}
			}

			foreach (var key in removeKeys)
			{
				dict.Remove(key);
			}
		}
	}
}
