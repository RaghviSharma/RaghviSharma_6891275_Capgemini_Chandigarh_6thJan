using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DateFormat
{
    internal class UserProgramCode
    {
        public static string findDay(string date,int num)
        {
            string ans = "";
            string pattern = @"\d{2}/\d{2}/\d{4}";
            if(Regex.IsMatch(date,pattern))
            {
                DateOnly dt = DateOnly.Parse(date);
                dt = dt.AddYears(num);
                ans = dt.ToString("MMMM");
            }
            return ans;
        }
    }
}
