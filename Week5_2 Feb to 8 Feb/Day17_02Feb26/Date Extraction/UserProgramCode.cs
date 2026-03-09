using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Date_Extraction
{
    internal class UserProgramCode
    {
        public static string extractDate(string date)
        {
            string ans = "";
            string pattern = @"[\b\d{2}/\d{2}/\d{2}\b]+";
            MatchCollection matches = Regex.Matches(date, pattern);
            foreach(Match m in matches)
            {
                ans += m.Value+"\n";
            }
            return ans;
        }
    }
}
