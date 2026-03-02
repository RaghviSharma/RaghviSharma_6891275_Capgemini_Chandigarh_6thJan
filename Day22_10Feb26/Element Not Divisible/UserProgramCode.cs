using System;
using System.Collections.Generic;
using System.Text;

namespace Element_Not_Divisible
{
    internal class UserProgramCode
    {
        public static int Count(int[] arr)
        {
            int count = 0;
            int finalCount = 0;
            for(int i=0;i<arr.Length;i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] % arr[j] != 0)
                        count++;
                }
                if (count == arr.Length - 1)
                    finalCount++;
                count = 0;
            }
            return finalCount;
        }
    }
}
