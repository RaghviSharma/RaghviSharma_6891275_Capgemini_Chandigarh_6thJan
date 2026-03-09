using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Is___Is_Not
{
	internal class UserProgramCode
	{
		public static string negativeString(string str)
		{
			string[] arr = str.Split(' ');
			StringBuilder ans=new StringBuilder();
			foreach (var i in arr)
			{
				if (i.Equals("is"))
				{
					ans.Append("is not ");
				}
				else
					ans.Append((i)+ " ");
			}
			return ans.ToString().Trim();
		}
	}
}
