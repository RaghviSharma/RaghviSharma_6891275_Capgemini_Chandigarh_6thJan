using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.RegularExpressions;

namespace Invoice_Number_Update_Using_Regular_Expressions
{
    internal class UserProgramCode
    {
        public static string UpdateCode(string input1, int input2)
        {
            int ans = 0;
            string pattern = @"CAP-[0-9]+";
            string result = "";
            if (Regex.IsMatch(input1, pattern))
            {
                string ptr = @"\d+";
                string rep=Regex.Match(input1, ptr).Value;
                ans = Convert.ToInt32(rep);
                ans += input2;
                result = input1.Replace(rep, Convert.ToString(ans));
            }
            return result;  
        }
    }
}
