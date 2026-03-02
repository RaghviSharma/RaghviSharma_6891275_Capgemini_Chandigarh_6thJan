using System;

public class FindNextVowel
{
	public string nextString(string input1)
	{
            string ans = "";
		foreach (char ch in input1)
		{
			if (!char.IsLetter(ch))
			{
				return "Invalid input";
			}
			bool isUpper = char.IsUpper(ch);
			char lower = char.ToLower(ch);
			if ("aeiou".Contains(lower))
			{
				char next = (char)(lower + 1);
				ans += isUpper ? char.ToUpper(next) : next;
			}
			else
			{
				char nextVowel = 'a';
				if (lower < 'e') nextVowel = 'e';
				else if (lower < 'i') nextVowel = 'i';
				else if (lower < 'o') nextVowel = 'o';
				else if (lower < 'u') nextVowel = 'u';
				else nextVowel = 'a';
				ans += isUpper ? char.ToUpper(nextVowel) : nextVowel;
			}
		}
		return ans;
	}
}
