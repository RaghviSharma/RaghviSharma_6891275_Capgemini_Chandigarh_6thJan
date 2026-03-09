using System;
using System.Collections.Generic;
using System.Text;

namespace Add_substring
{
    internal class UserProgramCode
    {
        public static string InsertAtLoc(string str,string s,int loc)
        {
            str = str.Insert(loc, s);
            return str;
        }
    }
}
