using System;
using System.Collections.Generic;
using System.Text;

namespace All_words_are_anagram
{
    internal class UserProgramCode
    {
        public static Boolean check(string[] arr)
        {
            if(arr==null||arr.Length==0)
                return false;
            char[] check = arr[0].ToCharArray();
            Array.Sort(check);
            string valid = new string(check);

            for (int i = 1; i < arr.Length; i++)
            {
                char[] ch = arr[i].ToCharArray();
                Array.Sort(ch);
                string equal = new string(ch);
                if (valid != equal)
                    return false;
            }
            return true;
        }
    }
}
