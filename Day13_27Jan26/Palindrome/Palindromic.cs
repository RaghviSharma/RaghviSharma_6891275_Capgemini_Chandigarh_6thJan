using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    internal class Palindromic
    {
        public Boolean check(string str)
        {
            string ans = "";
            int i = str.Length;
            while (i != 0)
            {
                --i;
                ans += str[i];

            }
            if (ans.Equals(str))
                return true;
            return false;

        }
    }
}


