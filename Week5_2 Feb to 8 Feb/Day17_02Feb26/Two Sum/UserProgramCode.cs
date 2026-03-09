using System;
using System.Collections.Generic;
using System.Text;

namespace Two_Sum
{
    internal class UserProgramCode
    {
        public static int[] twoSum(int[] nums,int target)
        {
            int[] ans = new int[2];
            for(int i=1;i<nums.Length;i++)
            {
                if (nums[i] + nums[i-1]==target)
                {
                    ans[0] = i-1;
                    ans[1] = i;
                }
            }
            return ans;
        }
    }
}
