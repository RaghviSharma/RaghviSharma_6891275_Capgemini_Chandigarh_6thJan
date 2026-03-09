using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Maximum_Frequency
{
    internal class UserProgramCode
    {
        public static int findFreq(int[] nums)
        {
            Dictionary<int, int> dt = new Dictionary<int, int>();
            
            foreach (int i in nums)
            {
                if (dt.ContainsKey(i))
                {
                    dt[i]++;
                }
                else dt[i] = 1;
            }
            int MaxCount = int.MinValue;
            int ans = 0;
            foreach (var (key, value) in dt)
            {
                MaxCount = Math.Max(value, MaxCount);
            }
            foreach (var (key, value) in dt)
            {
                if (MaxCount == value)
                    ans += value;
            }
            return ans;
        }
    }
}
