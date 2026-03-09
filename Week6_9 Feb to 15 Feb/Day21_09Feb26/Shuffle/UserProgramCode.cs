using System;
using System.Collections.Generic;
using System.Text;

namespace UserProgramCode
{
    internal class UserProgramCode
    {
        public static Boolean perfectShuffle(string z, string x, string y)
        {
            //z=abcdef x=adf y=bcf
            if (z.Length != x.Length + y.Length)
                return false;
            int i = 0;
            int j = 0;
            for (int k = 0; k < z.Length; k++)
            {
                if (i < x.Length && z[k] == x[i])
                    i++;
                else if (j < y.Length && z[k] == y[j])
                    j++;
                else
                    return false;
            }
            return (i==x.Length&&j==y.Length);
        }
    }
}
