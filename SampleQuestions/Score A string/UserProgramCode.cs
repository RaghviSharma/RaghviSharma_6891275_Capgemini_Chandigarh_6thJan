using System;
using System.Collections.Generic;
using System.Text;

namespace Score_A_string
{
    internal class UserProgramCode
    {
        //abba
        public static Boolean isPalindrome(string s)
        {
            //char[] arr=s.ToCharArray();
            //arr.Reverse();
            //if(s==new string(arr))
            //    return true;
            //return false;
            string check = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                check += s[i];
            }
            if(check==s)
                return true;
            return false;

        }
        public static int FindScore(string s)
        {
            int score = 0;
            if (string.IsNullOrEmpty(s))
                return 0;
            for(int i=0;i<s.Length;i++)
            {
                if (i<=s.Length-4&&isPalindrome(s.Substring(i, 4)))
                    score += 5;
                if (i<=s.Length-5&&isPalindrome(s.Substring(i, 5)))
                    score += 10;
            }
            return score;
        }
    }
}
