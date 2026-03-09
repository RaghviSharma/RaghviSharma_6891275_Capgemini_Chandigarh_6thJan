using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Hashtag_Extraction
{
    internal class UserProgramCode
    {
        public static string FindHashTags(string tags)
        {
            string ans = "";
            string pattern = @"#[\b0-9A-Za-z\b]+";
            MatchCollection matches = Regex.Matches(tags, pattern);
            foreach (Match m in matches)
            {
                ans += m.Value + "\n";
            }
            return ans;
        }
    }
}
