using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Employee_Designation
{
    internal class UserProgramCode
    {
		public static string[] getEmployee(string[] input1, string input2)
		{
			string[] ans;
			List<string> temp= new List<string>();
			foreach (var item in input1)
			{
				string pattern = @"[^a-zA-Z0-9]";
				if (Regex.IsMatch(item, pattern)||Regex.IsMatch(input2,pattern))
				{
					ans = new string[1];
					ans[0] = "Invalid Input";
					return ans;
				}
			}
			int j = 1;
			for (int i = 0; i < input1.Length; i+=2)
			{
				if (input1[j]==input2)
				{
					temp.Add(input1[i]);
					
				}
				j += 2;
			}
			if (temp.Count == 0)
			{
				temp.Add($"No employee for {input2} designation");
				return temp.ToArray();
			}
			if(temp.Count==input1.Length/2)
			{
				temp.Clear();
				temp.Add($"All employees belong to {input2} designation");
				
			}
			return temp.ToArray();
		}
	}
}
