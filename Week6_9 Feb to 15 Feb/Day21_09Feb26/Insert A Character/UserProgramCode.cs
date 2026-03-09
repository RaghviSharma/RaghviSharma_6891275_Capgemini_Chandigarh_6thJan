using System;
using System.Collections.Generic;
using System.Text;

namespace Insert_A_Character
{
    internal class UserProgramCode
    {
        public static string InsertChar(string str,char ch,int loc)
        {
            str = str.Insert(loc-1,ch.ToString());
            return str;
        }
    }
}
