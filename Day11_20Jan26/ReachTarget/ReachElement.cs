using System;
using System.Collections.Generic;
using System.Text;

namespace ReachTarget
{
    internal class ReachElement
    {
        public int findNo(int num,int target)
        {
            
            if(target==num)
                return 0;
            if(num<0||num>target*3)
                return int.MaxValue;
			int a = int.MaxValue, b = int.MaxValue, c = int.MaxValue;
			int minAns = int.MaxValue;
            if (num < target)
            {
                a = findNo(num * 3, target);
                b = findNo(num + 2, target);
			}
            else
            {
                c = findNo(num - 1, target);
            }
            minAns = 1+Math.Min(minAns, Math.Min(a, Math.Min(b, c)));
            return minAns;
            
        }
    }
}
