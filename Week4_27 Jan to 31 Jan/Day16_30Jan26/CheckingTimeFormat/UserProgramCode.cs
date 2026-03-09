using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CheckingTimeFormat
{
    internal class UserProgramCode
    {
        public static Boolean checkTime(string time)
        {
            int hr = Convert.ToInt32(time.Substring(0, 2));
            int min=Convert.ToInt32(time.Substring(3, 2));
            string format = time.Substring(5, 2);
            if((hr<=12&&hr>=1) &&min<60&&min>=0&& (format=="am"||format=="pm"))
            {
                string pattern = @"^[0-9]{2}:[0-9]{2}[a-z]{2}$";
                if (Regex.IsMatch(time, pattern))
                    return true;
            }
            return false;
        }
    }
}
