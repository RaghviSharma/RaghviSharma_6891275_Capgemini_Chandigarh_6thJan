using System;
using System.Collections.Generic;
using System.Text;

namespace LongestSubstringWithoutRepeating
{
    internal class FindSubstring
    {
        public void Find(string str)
        {
            int left = 0;
            int start = 0;
            int maxLen = 0;
            HashSet<char> set=new HashSet<char>();
            for(int right=0;right<str.Length; right++)
            {
                while (set.Contains(str[right]))
                {
                    set.Remove(str[left]);
                    left++;
                }
                set.Add(str[right]);
                if(right-left+1>maxLen)
                {
                    maxLen = right-left+1;
                    start = left;
                }
            }
            Console.WriteLine(str.Substring(start, maxLen));
        }
    }
}
