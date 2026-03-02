using System;
using System.Collections.Generic;
using System.Text;

namespace Delete_Consequtive_Pairs_Of_Vowels
{
    internal class UserProgramCode
    {
        public static Boolean isVowel(char s)
        {
            if("aeiou".Contains(char.ToLower(s)))
                return true;
            return false;
        }
        public static int RemoveCon(string str)
        {
            int count = 0;
            for(int i=1;i<str.Length;i++)
            {
                if (isVowel(str[i]) && isVowel(str[i-1]))
                {
                    count++;
                    i++;
                }
            }
            return count;
        }
    }
}
