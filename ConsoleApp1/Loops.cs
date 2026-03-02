using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value of x:");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table of "+x+"is:");
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0}*{1}={2}", x, i, x * i);
            }
            int[] arr = new int[x];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = i + 1;
            }
            Console.WriteLine("Elements of array are:");
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }

        }
    }
}
