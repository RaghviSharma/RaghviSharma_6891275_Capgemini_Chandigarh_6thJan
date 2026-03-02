using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Factorial
    {
        public int FactHelp(int x)
        {
            if (x == 0)
                return 1;
            return x * FactHelp(x - 1);
        }
        public int Fact()
        {
			Console.WriteLine("Enter the number to find factorial:");
			int x = int.Parse(Console.ReadLine());
			if (x < 0)
            {
                return -1;
            }
             if (x > 7)
                return -2;
            else 
            {
                return FactHelp(x);
            }
        }
        static void Main(string[] args)
        {
           
            Factorial obj=new Factorial();
            int ans= obj.Fact();
            Console.WriteLine(ans);
            
        }

    }
}
