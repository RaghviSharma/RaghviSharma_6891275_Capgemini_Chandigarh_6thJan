using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseString
{
    internal class Reverse
    {
        public void rev(string str)
        {
            int len=str.Length;
            string ans = "";
            int i = len;
            while(i>0)
            {
                --i;
                ans += str[i];
            }
            Console.WriteLine("Reversed string is :" + ans);
        }
    }
}
