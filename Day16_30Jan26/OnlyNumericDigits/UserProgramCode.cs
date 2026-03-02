using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OnlyNumericDigits
{
    internal class UserProgramCode
    {
        public static int check(string[] input1)
        {
            foreach (string s in input1)
            {
                string pattern = @"^[0-9].+$";
                if (Regex.IsMatch(s, pattern))
                    return 1;
            }
            return -1;
        }
    }
}
