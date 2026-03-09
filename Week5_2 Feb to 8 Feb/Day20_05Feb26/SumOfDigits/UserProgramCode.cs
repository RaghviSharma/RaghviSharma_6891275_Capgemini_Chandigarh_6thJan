using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfDigits
{
    internal class UserProgramCode
    {
        public static int FindSum(int n)
        {
            int temp = n;
            int ans = 0;
            while(temp!=0)
            {
                ans += temp % 10;
                temp = temp / 10;
            }
            return ans;
        }
    }
}
