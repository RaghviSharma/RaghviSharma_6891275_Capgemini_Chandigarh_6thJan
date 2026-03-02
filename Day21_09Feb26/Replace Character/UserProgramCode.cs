using System;
using System.Collections.Generic;
using System.Text;

namespace Replace_Character
{
    internal class UserProgramCode
    {
        public static string Replace(string str, char ch, char newCh)
        {
            string ans = "";
            char[] arr=str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ch)
                {
                    arr[i] = newCh;
                    break;
				}
            }
            foreach (char c in arr)
            {
                ans += c;
            }
            return ans;
 
        }
    }
}
