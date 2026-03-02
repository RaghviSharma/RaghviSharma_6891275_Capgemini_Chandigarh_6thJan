using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Form_String
{
    internal class UserProgramCode
    {
	    public static string formString(string[] input1, int input2)
		{
			string ans = "";
			foreach (string s in input1)
			{
				string pattern = @"[^a-zA-Z0-9]";
				if (Regex.IsMatch(s, pattern))
				{
					return "-1";
				}
			}
			foreach(string s in input1)
			{
				if (input2<=s.Length)
					ans += s[input2-1];
				else
					ans += '$';
			}
			return ans;
		}

	}
}
