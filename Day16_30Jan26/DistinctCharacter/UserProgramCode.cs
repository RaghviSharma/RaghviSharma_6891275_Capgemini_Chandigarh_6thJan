using System;
using System.Collections.Generic;
using System.Text;

namespace DistinctCharacter
{
    internal class UserProgramCode
    {
        public static string findDistinct(string text)
        {
            string ans = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    ans += text[i];
                else if (!ans.Contains(text[i]))
                    ans += text[i];
            }
            return ans;
        }
    }
}
