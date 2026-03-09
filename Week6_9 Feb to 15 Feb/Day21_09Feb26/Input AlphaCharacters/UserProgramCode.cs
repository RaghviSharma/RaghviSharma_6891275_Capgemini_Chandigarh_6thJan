using System;
using System.Collections.Generic;
using System.Text;

namespace Input_AlphaCharacters
{
    internal class UserProgramCode
    {
        public static string Arrange(string str)
        {
            string result = "";
            char[] ch=str.ToCharArray();
            char[] ans = new char[str.Length];
            int left = 0;
            int right = str.Length - 1;
            for(int i=0;i<ch.Length;i++)
            {
                if (Char.IsDigit(ch[i]))
                {
                    ans[left++] = ch[i];
                }
                else if (Char.IsLetter(ch[i]))
                {
                    ans[right--] = ch[i];
                }
                else if (ch[i] == ' ')
                    continue;
                else
                    return "Invalid";
            }
            for (int i = 0; i < ans.Length; i++)
            {
                result = string.Join(" ", ans);
            }
            return result;
        }
    }
}
