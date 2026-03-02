using System;
using System.Collections.Generic;
using System.Text;

namespace Remove_Last_Occurrence
{
    internal class UserProgramCode
    {
        public static string Remove(string str, string word)
        {
            string[] space = str.Split(' ');
            string ans = "";
            for (int i = space.Length - 1; i >= 0; i--)
            {
                if (word==space[i])
                {
                    space[i] = "";
                    break;
                }
            }
            ans = string.Join(" ", space);
            return ans;
        }
    }
}
