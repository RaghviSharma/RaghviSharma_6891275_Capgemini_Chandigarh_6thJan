using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Methods
    {
        void hello()
        {
            Console.WriteLine("No paramters no output");
        }
        void value(int x)
        {
            Console.WriteLine(x); 
        }
        int add(int x, int y)
        {
            return x + y;
        }
        string check()
        {
            return "Hello";
        }
        void addition(int x,int y,ref int a,ref int b)
        {
            a = x + y;
            b = x - y;
        }
        void multiply(int x,int y,out int a,out int b)
        {
            a = x * y;
            b = x / y;
        }
        static void Main(string[] args)
        {
            Methods obj=new Methods();
            obj.hello();
            obj.value(1);
            obj.value(2);
            Console.WriteLine(obj.check());
            Console.WriteLine(obj.add(2, 3));
            int m = 0, n = 0;
            obj.addition(2, 3, ref m, ref n);
            Console.WriteLine("a is:"+m+" B is:"+n);
            obj.multiply(20,10,out int y,out int z);
            Console.WriteLine("a is:" + y + " b is:" + z);
        }

    }
}
