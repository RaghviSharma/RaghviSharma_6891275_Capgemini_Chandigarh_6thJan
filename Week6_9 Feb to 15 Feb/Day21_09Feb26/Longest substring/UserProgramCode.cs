using System;
using System.Collections.Generic;
using System.Text;

namespace Longest_substring
{
    internal class UserProgramCode
    {
        public static Boolean isPalindrome(string s)
        {
            string ans = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i];
            }
           return (ans == s) ? true : false;
        }
        
        public static int FindLength(string str)
        {
            //abcdedcfg
            int ans = 0;
            int left = 0;
            int right = str.Length;
            while (left<right)
            {
                if (str.Substring())
            }

        }
    }
}
