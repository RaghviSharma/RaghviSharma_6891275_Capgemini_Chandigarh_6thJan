using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Strong_Password
{
    internal class UserProgramCode
    {
        public static string checkPswrd(string password)
        {
            if(password.Length<8)
            {
                return "Weak";
            }
            string pattern = @"^[a-zA-Z0-9@$%*!?&]+$";
            if (Regex.IsMatch(password, pattern))
                return "Strong";
            return "Weak";
        }
    }
}
