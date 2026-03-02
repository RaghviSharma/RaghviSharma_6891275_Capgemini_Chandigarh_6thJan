using System;
using System.Collections.Generic;
using System.Text;

namespace Score_Of_the_String
{
    internal class UserProgramCode
    {
        public static Boolean palindrome(string s)
        {
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i];
            }
            if(rev==s)
                return true;
            return false;
        }
        public static int FindScore(string input)
        {
            int ans = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i<input.Length-3 && palindrome(input.Substring(i, 4)))
                    ans += 5;
                if (i < input.Length - 4 && palindrome(input.Substring(i, 5)))
                    ans += 10;
            }
            return ans;
        }
    }

}
