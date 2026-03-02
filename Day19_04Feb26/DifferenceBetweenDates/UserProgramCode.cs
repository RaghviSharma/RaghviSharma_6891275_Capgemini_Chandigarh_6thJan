using System;
using System.Collections.Generic;
using System.Text;

namespace DifferenceBetweenDates
{
    internal class UserProgramCode
    {
        public static int difference(string date1,string date2)
        {
            DateTime dt = DateTime.Parse(date1);
            DateTime dt2 = DateTime.Parse(date2);
            int diff = Math.Abs(dt.DayOfYear - dt2.DayOfYear);
            return diff;    
        }
    }
}
