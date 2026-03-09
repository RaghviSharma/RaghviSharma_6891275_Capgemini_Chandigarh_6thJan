using System;
using System.Collections.Generic;
using System.Text;

namespace Sum_Largest_No_In_Range_CS2
{
    internal class SumLargest
    {
        public int find(int[] arr)
        {
            bool isNegative=false;
            bool isGreater = false;

            foreach(int i in arr)
            {
                if(i<0)
                    isNegative = true;
                if(i>100)
                    isGreater = true;
            }
            if (isNegative && isGreater)
                return -3;
            else if (isNegative)
                return -1;
            else if (isGreater)
                return -2;

            HashSet<int> unique=new HashSet<int>(arr);
            int[] maxElement = new int[10];
            foreach(int num in unique)
            {
                int idx = (num - 1) / 10;
                if (num > maxElement[idx])
                {
                    maxElement[idx] = num;
                }
            }
            int sum = 0;
            foreach(int num in  maxElement)
            {
                sum += num;
            }
            return sum;

        }
    }
}
