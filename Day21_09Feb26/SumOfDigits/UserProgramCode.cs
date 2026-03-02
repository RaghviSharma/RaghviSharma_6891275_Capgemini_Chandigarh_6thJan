using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfDigits
{
    internal class UserProgramCode
    {
        public static int findSum(int num)
        {
            int ans = 0;
            int temp = num;
            while(temp!=0)
            {
                ans += temp % 10;
                temp = temp / 10;
            }
            return ans;
        }
    }
}
