using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Valid_Email_Address
{
    internal class UserProgramCode
    {
        public static string Validation(string mail)
        {
            //raghvi29sharma@gmail.com
            string pattern = @"^[a-zA-Z0-9]+[a-zA-Z0-9.%_+-]*@[a-zA-Z.-]+\.[a-zA-Z]{2,}$";
            if(Regex.IsMatch(mail,pattern))
            {
                return "Valid";
            }
            return "Invalid";
		}
    }
}
