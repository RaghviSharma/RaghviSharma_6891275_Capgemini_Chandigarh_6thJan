using System;
using System.Collections.Generic;
using System.Text;

namespace CountVowel
{
    internal class VowelsInStr
    {
        public int count(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.ToLower(str[i]) == 'a' || char.ToLower(str[i]) == 'e' || char.ToLower(str[i]) == 'i' || char.ToLower(str[i]) == 'o' || char.ToLower(str[i] )== 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
