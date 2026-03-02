using System;
using System.Collections.Generic;
using System.Text;

namespace Find_Occurence_in_second
{
    internal class UserProgramCode
    {
        public static void FindO(List<int> l1,List<int> l2)
        {

            for(int i=0;i<l1.Count;i++)
            {
                int sum = 0;
                for(int j=0;j<l2.Count;j++)
                {
                    if (l1[i] == l2[j])
                    {
                        sum += l2[j];
                    }
                }
                Console.WriteLine(l1[i] + "-" + sum);
                
            }
        }
    }
}
