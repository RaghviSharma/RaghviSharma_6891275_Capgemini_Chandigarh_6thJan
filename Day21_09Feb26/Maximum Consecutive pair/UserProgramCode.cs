using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Maximum_Consecutive_pair
{
    internal class UserProgramCode
    {
        public static int FindConsec(string str)
        {
            int ans = 0;
           Stack<char> st = new Stack<char>();
            st.Push(str[0]);
            for (int i = 1; i < str.Length; i++)
            {
                if (st.Count!=0&&st.Peek() == str[i])
                {
                    ans++;
                    st.Pop();
                }
                else
                    st.Push(str[i]);
            }
            return ans;

        }
    }
}
