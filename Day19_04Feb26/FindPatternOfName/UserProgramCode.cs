using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FindPatternOfName
{
    internal class UserProgramCode
    {
        public static string find(string input1,string input2)
        {
            bool check = Regex.IsMatch(input2, @"[a-zA-Z]{15,}");
            if(check)
            {
                input1 = input1.Replace(input1.Substring(14), input2);
            }
            return input1;
        }
    }
}
