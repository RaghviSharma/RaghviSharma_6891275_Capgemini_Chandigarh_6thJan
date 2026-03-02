using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	internal class Key
	{
		public void Find()
		{
			int x;
			Console.WriteLine("Enter the value:");
			x = int.Parse(Console.ReadLine());
			if (x < 10 && x >= 0)
			{
				Console.WriteLine("Entered value is:" + x);
			}
			else
				Console.WriteLine("Not Allowed");

		}
		public void printP()
		{
			for (int i = 0; i <=5; i++)
			{
				for (int j =1; j<=5-i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}

			static void Main(string[] args)
			{
				//Key obj = new Key();
				//obj.Find();
				Key p = new Key();
				p.printP();
			}

		}
	}

