using System;
using System.Collections.Generic;
using System.Text;

namespace Remove_Duplicates
{
    internal class UserProgramCode
    {
        public static int removeDup(int[] nums)
        {
            int[] ans=new int[nums.Length];
            ans[0] = nums[0];
            int k = 1;
            for(int i=1;i<nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    ans[k] = nums[i];
                    k++;
                }
                else
                    continue;
            }
            return k;

        }
    }
}
