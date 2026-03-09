using System;
using System.Collections.Generic;
using System.Text;

namespace Sort_Pipe_seperated_words
{
    internal class UserProgramCode
    {
        public static string findWords(string str)
        {
            string ans = "";
            string[] arr = str.Split('|');
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                ans = string.Join("|", arr);
            }
            return ans;
        }
    }
}
