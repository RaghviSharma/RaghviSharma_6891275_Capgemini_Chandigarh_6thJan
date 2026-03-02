using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Valid_Phone_Number
{
    internal class UserProgramCode
    {
        public static string Number(string phNo)
        {
            //int count = 0;
            //string ans = "";
            //for (int i = 0; i < phNo.Length; i++)
            //{
            //    if (Char.IsDigit(phNo[i]))
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        count = 0;
            //    }
            //    if(count==10)
            //    {
            //        ans += phNo.Substring(i - 9, 10)+"\n";
            //    }
            //}

            //return ans;
            string pattern = @"\b\d{10}\b";
            MatchCollection matches = Regex.Matches(phNo, pattern);
            string ans = "";
            foreach(Match m in matches)
            {
                 ans += m.Value+"\n";
            }
            return ans;
        }
	}
}
