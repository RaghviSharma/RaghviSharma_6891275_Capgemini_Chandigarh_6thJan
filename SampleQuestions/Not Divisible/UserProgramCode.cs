using System;
using System.Collections.Generic;
using System.Text;

namespace Not_Divisible
{
    internal class UserProgramCode
    {
        public static int findN(int[] arr)
        {
            int totalC = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j]!=0&&arr[i] % arr[j] == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                    totalC++;
            }
            return totalC;
        }
    }
}
