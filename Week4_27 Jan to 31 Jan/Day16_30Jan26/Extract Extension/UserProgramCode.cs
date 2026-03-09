using System;
using System.Collections.Generic;
using System.Text;

namespace Extract_Extension
{
    internal class UserProgramCode
    {
        public static string extract(string input1)
        {
            int n=input1.Length;
            int i = 0;
            while (input1[i]!='.')
            {
                i++;
            }
            string ans = input1.Substring(i+1);
            return ans;
        }
    }
}
