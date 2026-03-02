using System;
using System.Collections.Generic;
using System.Text;

namespace Second_Largest_Num
{
    internal class UserProgramCode
    {
        public static int findSecMax(int[] arr)
        {
            int max = int.MinValue;
            int second = int.MinValue;
            foreach(int num in arr)
            {
                if(num>max)
                {
                    second = max;
                    max = num;
                }
                else if(num>second&&num<max)
                {
                    second = num;
                }
            }
            return (second == int.MinValue ? -1 : second); 
        }
    }
}
