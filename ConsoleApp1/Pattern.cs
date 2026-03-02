using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Pattern
    {
        public void printP()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 5; j > i; j++)
                {
                    Console.Write("*");
                }
            }

            static void Main(string[] args)
            {
                Pattern p = new Pattern();
                p.printP();
            }
        }
    }
}
