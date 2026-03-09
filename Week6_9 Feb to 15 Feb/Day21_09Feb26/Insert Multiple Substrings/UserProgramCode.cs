using System;
using System.Collections.Generic;
using System.Text;

namespace Insert_Multiple_Substrings
{
    internal class UserProgramCode
    {
        public static string Insertion(string str,string s,int loc)
        {
            str = str.Insert(loc, s);
            return str;
        }
    }
}
