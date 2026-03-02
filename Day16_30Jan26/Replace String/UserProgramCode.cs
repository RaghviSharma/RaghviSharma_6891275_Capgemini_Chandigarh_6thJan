using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Replace_String
{
    internal class UserProgramCode
    {
        public static string replace(string input1, int idx, char ch)
        {
            string[] array =input1.Split(' ');
            foreach(string s in array)
            {
                string pattern = @"[^a-zA-z]";
                if (Regex.IsMatch(s, pattern))
                    return "-1";
            }
            if (idx < 0)
                return "-2";
            if (Char.IsLetterOrDigit(ch))
                return "-3";
            string ann = array[idx-1];
            int count=ann.Length;
            string addCh = "";
            while(count>0)
            {
                addCh += ch;
                count--;
            }
            string output = input1.Replace(ann,addCh);
            return output;
        }
    }
}
