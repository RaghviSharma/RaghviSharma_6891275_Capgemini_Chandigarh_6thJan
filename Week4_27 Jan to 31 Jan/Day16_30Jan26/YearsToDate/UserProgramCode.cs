using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.RegularExpressions;

namespace YearsToDate
{
    internal class UserProgramCode
    {
        public static string addYear(string date, int num)
        {
            string a="";
            string pattern = @"^\d{2}-\d{2}-\d{4}$";
            
			if (Regex.IsMatch(date, pattern))
            {
                DateOnly dt=DateOnly.Parse(date);
                dt=dt.AddYears(num);
                return dt.ToString();
            }
            return "-1";
           
        }
    }
}
