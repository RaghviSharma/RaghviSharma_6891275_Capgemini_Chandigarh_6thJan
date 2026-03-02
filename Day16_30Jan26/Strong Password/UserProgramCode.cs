using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Strong_Password
{
    internal class UserProgramCode
    {
        public static int check(string code)
        {
			string pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@#_])[A-Za-z][A-Za-z0-9@#_]{6,}[A-Za-z0-9]$";
			if (Regex.IsMatch(code, pattern))
                return 1;
            return -1;
        }
    }
}
