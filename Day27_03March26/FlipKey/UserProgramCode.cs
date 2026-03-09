using System;
using System.Text.RegularExpressions;

namespace FlipKey
{
	internal class UserProgramCode
	{
		public static string CleanseAndInvert(string input)
		{
			
			if (input == null)
				return "";

			string pattern = @"^[a-zA-Z]{6,}$";
			if (!Regex.IsMatch(input, pattern))
				return "";

			input = input.ToLower();

			string filtered = "";
			foreach (char c in input)
			{
				if ((int)c % 2 != 0)   
				{
					filtered += c;
				}
			}

			char[] arr = filtered.ToCharArray();
			Array.Reverse(arr);
			string reversed = new string(arr);
			char[] finalArr = reversed.ToCharArray();
			for (int i = 0; i < finalArr.Length; i++)
			{
				if (i % 2 == 0)
				{
					finalArr[i] = Char.ToUpper(finalArr[i]);
				}
			}

			return new string(finalArr);
		}
	}
}