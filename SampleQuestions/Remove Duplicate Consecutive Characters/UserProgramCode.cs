using System;
using System.Collections.Generic;
using System.Text;

namespace Remove_Duplicate_Consecutive_Characters
{
    internal class UserProgramCode
    {
        public static string Final(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            Stack<char> st = new Stack<char>();
            st.Push(str[str.Length-1]);
            for (int i = str.Length-2; i >=0; i--)
            {
                if (st.Count > 0 && st.Peek() == str[i])
                    st.Pop();
                else
                    st.Push(str[i]);
            }
            string ans = "";
            char[] arr=st.ToArray();
            
            return new string(arr);
		}
    }
}
