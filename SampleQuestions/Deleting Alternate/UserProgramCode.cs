using System;
using System.Collections.Generic;
using System.Text;

namespace Deleting_Alternate
{
    internal class UserProgramCode
    {
        public static string DeleteAlternate(string str)
        {
            string ans = "";
            if (str.Length == 1)
                return str;
            if (string.IsNullOrEmpty(str))
                return str;
             for(int i=0;i<str.Length;i=i+2)
             {
                    ans+= str[i];
             }    
            return ans;
        }
    }
}
