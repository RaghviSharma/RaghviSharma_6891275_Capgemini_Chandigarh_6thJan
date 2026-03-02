using System;
using System.Collections.Generic;
using System.Text;

namespace Perfect_Shuffle
{
    internal class UserProgramCode
    {
        public static Boolean isPerfect(string z,string x,string y)
        {
            if(string.IsNullOrEmpty(z)||x==null||y==null||z.Length!=x.Length+y.Length)
                return false;
            int j = 0;
            int k = 0;
            for(int i=0;i<z.Length;i++)
            {
                if (j<x.Length&&z[i] == x[j])
                    j++;
                else if (k<y.Length&&z[i] == y[k])
                    k++;
                else
                    return false;
            }
            return j==x.Length&&k==y.Length;
        }
    }
}
