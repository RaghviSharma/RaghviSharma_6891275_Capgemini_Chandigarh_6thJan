using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Location_Code_Update_in_Invoice_Numbers
{
    internal class UserProgramCode
    {
        public static string UpdatedLocation(string input1, string input2)
        {
            string pattern = @"CAP-\w{3}-\d{3}";
            if (Regex.IsMatch(input1, pattern))
            {
                string location = input1.Substring(4, 3);
                input1 = input1.Replace(location, input2);
                return input1;
            }
            return "Invalid String";
        }
    }
}
