using System;
using System.Collections.Generic;
using System.Text;

namespace Next_Greater_Element
{
    internal class UserProgramCode
    {
        public static int FindCount(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int X = arr[i];
                if (arr[i + 1] > X && arr[i + 1] % X == 0)
                    count++;
            }
            return count;
        }
    }
}
