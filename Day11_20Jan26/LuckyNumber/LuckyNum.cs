using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyNumber
{
    internal class LuckyNum
    {
        public static Boolean isNonPrime(int n)
        {
            for(int i=2;i<n;i++)
            {
                if (n % i == 0)
                    return true;
            }
            return false;
        }
        public static int Sum(int n)
        {
            int sum = 0;
            int temp = n;
            while(temp!=0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            return sum;
        }
        public static int countLN(int n,int m)
        {
            int count = 0;
            for(int i=n;i<=m;i++)
            {
                if(isNonPrime(i))
                {
                    if (Sum(i * i) == Sum(i) * Sum(i))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
