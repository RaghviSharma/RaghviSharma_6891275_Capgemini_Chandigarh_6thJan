using System;
using System.Collections.Generic;
using System.Text;

namespace AlphabetAndVowel
{
	internal class RemoveConsonant
	{
		public string find(string input1, string input2)
		{
			int l1 = input1.Length;
			int l2 = input2.Length;
			string output = "";
			for (int i = 0; i < l1; i++)
			{
				char ch = input1[i];

				if (ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u')
				{
					for (int j = 0; j < l2; j++)
					{
						if (ch == input2[j])
						{
							output += ch;
							break;
						}
					}
				}
			}
			string temp = input1;
			foreach (char c in output)
			{
				temp = temp.Replace(c.ToString(), "");
			}
			string res = "";
			res += temp[0];

			for (int i = 1; i < temp.Length; i++)
			{
				if (temp[i] != temp[i - 1])
				{
					res += temp[i];
				}
			}

			return res;
		}
	}
}
