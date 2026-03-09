using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Digit_Sum_in_String_Array
{
    internal class UserProgramCode
    {
        public static int find(string[] input2, int input1)
        {
            int sum = 0;
            foreach (var i in input2)
            {
                string pattern = @"[^a-zA-Z0-9]";
                if (Regex.IsMatch(i, pattern))
                {
                    return -1;
                }
                foreach (var ch in i)
                {
                    if (Char.IsDigit(ch))
                        sum += ch-'0';
                }
            }
			return sum;
		}
    }
}
