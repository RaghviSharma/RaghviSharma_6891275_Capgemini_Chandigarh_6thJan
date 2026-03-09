using System;
using System.Collections.Generic;
using System.Text;

namespace FindSumOfPairs
{
    internal class UserProgramCode
    {
        public static int find(int[] arr,int n)
        {
            if(arr==null||arr.Length<2||n==0)
                return 0;
            int ans = 0;
            for(int i=1;i<n;i++)
            {
                if ((arr[i] + arr[i - 1]) % n == 0)
                    ans++;
            }
            return ans;
        }
    }
}
