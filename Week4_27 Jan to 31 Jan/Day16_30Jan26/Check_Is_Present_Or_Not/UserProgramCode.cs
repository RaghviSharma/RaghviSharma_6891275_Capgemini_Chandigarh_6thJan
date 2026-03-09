using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Check_Is_Present_Or_Not
{
    internal class UserProgramCode
    {
        public static bool IsPresent(string input1, string input2, string input3)
        {
            if (input1.Contains(input2) && input1.Contains(input3))
            {
                int input2Idx = input1.IndexOf(input2);
                int input3Idx = input1.IndexOf(input3);
                if (input2Idx < input3Idx)
                    return true;
                
            }
            return false;
        }
    }
}
