using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Correct
    {
        public void Ans()
        {
            Console.WriteLine("What is correct way to declare variable?");
            Console.WriteLine("a. int 1x=10");
            Console.WriteLine("b. int x=10");
            Console.WriteLine("c. float x=10.0f");
            Console.WriteLine("d. string x='10'");
            Console.WriteLine("Enter the write choice:");
            string ans = Console.ReadLine();
            if (ans == "b")
                Console.WriteLine("Correct Answer");
            else
                Console.WriteLine("Incorrect");

        }
        static void Main(string[]args)
        {
            Correct obj = new Correct();
            obj.Ans();
        }
    }
}
