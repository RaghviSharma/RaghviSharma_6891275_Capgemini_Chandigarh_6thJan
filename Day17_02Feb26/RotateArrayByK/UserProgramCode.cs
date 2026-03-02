using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

namespace RotateArrayByK
{
    internal class UserProgramCode
    {
        public static int[] reverse(int[] nums,int start,int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start++] = nums[end];
                nums[end--] = temp;
            }
            return nums;
            
        }
        public static int[] Rotation(int[] nums,int k)
        {
            int[] res = reverse(nums, 0, nums.Length-1);
            res = reverse(nums, 0, k-1);
            res = reverse(res, nums.Length - k-1, nums.Length-1);
            return res;
        }
        
    }
}
