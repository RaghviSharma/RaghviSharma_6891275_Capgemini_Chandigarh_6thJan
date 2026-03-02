using System;
using System.Collections.Generic;
using System.Text;

namespace RomanToDecimal
{
    internal class UserProgramCode
    {
        public static int convertRomanToDecimal(string str)
        {
            Dictionary<char,int> dict = new Dictionary<char,int>();
            dict.Add('I', 1);
			dict.Add('V', 5);
			dict.Add('X', 10);
			dict.Add('L', 50);
			dict.Add('C', 100);
			dict.Add('D', 500);
			dict.Add('M', 1000);

			int ans = 0;
			for(int i=0;i<str.Length-1;i++)
			{
				if (dict.ContainsKey(str[i]))
				{
					if (str[i] < str[i + 1])
					{
						ans -= dict[str[i]];
					}
					else
						ans += dict[str[i]];
				}
				else
					return -1;
			}
			return ans + dict[str[str.Length-1]];

		}

	}
}
