using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Practice
    {
        public void Great()
        {
			int x, y, z;
			Console.Write("Enter value of x:");
			x = int.Parse(Console.ReadLine());

			Console.Write("Enter value of y:");
			y = int.Parse(Console.ReadLine());

			Console.Write("Enter value of z:");
			z = int.Parse(Console.ReadLine());

			if (x > y && (y > z))
			{
				Console.WriteLine("x is greatest");
			}
			else if (y > z && z > x)
			{
				Console.WriteLine("Y is Greatest");
			}
			else if (z > x && z > y)
			{
				Console.WriteLine("z is greatest");

			}
			else
			{
				Console.WriteLine("Numbers are equal");
			}
		}
		static void Main(string[] args)
        {
			Practice obj=new Practice();
			obj.Great();
        }
    }
}

