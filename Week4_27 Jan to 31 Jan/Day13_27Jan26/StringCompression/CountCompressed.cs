using System;
using System.Collections.Generic;
using System.Text;

namespace StringCompression
{
    internal class CountCompressed
    {
        public string compress(string str)
        {
            string ans = "";
            int count = 1;
            if (str == null)
            {
                return ans;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i-1])
                {
                    count++;
                }
                else
                {
                    ans += str[i-1];
                        ans += count;
                    count = 1;
                }
            }
            ans += str[str.Length - 1];
                ans += count;
            return ans;
        }
    }
}
