using System;
using System.Collections.Generic;
using System.Text;

namespace Insert_Element
{
    internal class UserProgramCode
    {
        public static string Insertion(string s,char c,int loc)
        {
            if(s!=null&&loc<=s.Length&&loc>=0)
            s = s.Insert(loc,Convert.ToString(c));
            return s;
        }
    }
}
