using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum_Deletion
{
    internal class UserProgramCode
    {
        public static int DeleteCons(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;
            Stack<char> st = new Stack<char>();
            int count = 0;
            char c = str[0];
            st.Push(c);
            for (int i = 1; i<str.Length;i++)
            {
                if (st.Count!=0&&st.Peek() == str[i])
                {
                    count++;
                    st.Pop();
                }
                st.Push(str[i]);
            }
            return count;
        }
    }
}
