using System;
using System.Collections.Generic;
using System.Text;

namespace Replace_first_occurrence
{
    internal class UserProgramCode
    {
        public static string ReplaceC(string str,char ch,char newC)
        {
            if (str == null || ch == null || str.Length == 0)
                return str;
            int idx = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i]==ch)
                {
                    idx = i;
                    break;
                }
            }
            char[] cha = str.ToCharArray();
            cha[idx]=newC;
            return new string(cha);
        }
    }
}
