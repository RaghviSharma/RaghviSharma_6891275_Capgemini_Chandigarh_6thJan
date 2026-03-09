using System;
using System.Collections.Generic;
using System.Text;

namespace Delete_Alternate_Characters
{
    internal class UserProgramCode
    {
        public static string RemoveChars(string str)
        {
            string ans = "";
            for(int i=0;i<str.Length; i++)
            {
                if(i%2==0)
                {
                    ans+= str[i];
                }
            }
            return ans;
        }
    }
}
