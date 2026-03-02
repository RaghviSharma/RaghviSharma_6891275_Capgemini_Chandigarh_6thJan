using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    internal class SumLargest
    {
        public int find(int[] arr)
        {
            int sum = arr.Distinct().GroupBy(n => (n - 1) / 10).Select(g=>g.Max()).Sum();
            return sum;
        }
    }
}
