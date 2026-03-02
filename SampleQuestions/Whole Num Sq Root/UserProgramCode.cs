using System;
using System.Collections.Generic;
using System.Text;

namespace Whole_Num_Sq_Root
{
    internal class UserProgramCode
    {
        public static Boolean isSquare(int n)
        {
            int root = (int)Math.Sqrt(n);
            if (root * root == n)
                return true;
            return false;          
        }
        public static int FindClose(int n)
        {
            if (isSquare(n))
                return n;
            int leftTemp = n;
            int left = 0;
            int rightTemp = n;
            int right = 0;
            while(isSquare(leftTemp)!=true)
            {
                leftTemp--;
                left++;           
            }
            while(isSquare(rightTemp)!=true)
            {
                rightTemp++;
                right++;
            }
           int ans= left < right ? leftTemp : rightTemp;
            return ans;
        }
    }
}
