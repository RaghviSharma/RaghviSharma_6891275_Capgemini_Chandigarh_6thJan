using System;
using System.Collections.Generic;
using System.Text;

namespace Remove_And_Insert
{
    internal class UserProgramCode
    {
        public static string InsertAndDelete(string str,string s,string newS)
        {
            int loc = str.IndexOf(s);
            str = str.Remove(loc,s.Length);
            str = str.Insert(loc, newS);
            return str;
        }
    }
}
