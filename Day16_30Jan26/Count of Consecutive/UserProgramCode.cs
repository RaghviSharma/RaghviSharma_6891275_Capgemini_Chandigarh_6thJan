using System;
using System.Collections.Generic;
using System.Text;

namespace Count_of_Consecutive
{
    internal class UserProgramCode
    {
        public static int findCount(string str)
        {
            int count = 1;
            int finalC = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                    count++;
                if (count == 3)
                {
                    finalC++;
                    count = 0;
                }
            }
            return finalC;
        }
    }
}
