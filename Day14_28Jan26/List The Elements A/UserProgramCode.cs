using System;
using System.Collections.Generic;
using System.Text;

namespace List_The_Elements_A
{
    internal class UserProgramCode
    {
        public static List<int> GetElement(List<int> input1,int input2)
        {
            List<int> ans= new List<int>();
            foreach (int i in input1)
            {
                if(i<input2)
                {
                    ans.Add(i);
                }
            }
            if (ans.Count == 0)
            {
                ans.Add(-1);
            }
            return ans;

        }
    }
}
