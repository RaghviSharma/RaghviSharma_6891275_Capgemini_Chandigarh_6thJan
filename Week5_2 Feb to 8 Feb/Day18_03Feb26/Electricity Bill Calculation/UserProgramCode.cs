using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.RegularExpressions;

using System;
using System.Text.RegularExpressions;

namespace Electricity_Bill_Calculation
{
	internal class UserProgramCode
	{
		public static int MatchOrNot(string input, string patt)
		{
			if (Regex.IsMatch(input, patt))
			{
				return Convert.ToInt32(input.Substring(5));
			}

			return 0;
		}

		public static int Calculate(string input1, string input2, int input3)
		{
			string pattern = @"^[A-Z]{5}[0-9]{5}$";

			int reading1 = MatchOrNot(input1, pattern);
			int reading2 = MatchOrNot(input2, pattern);

			int units = Math.Abs(reading1 - reading2);

			return units * input3;
		}
	}
}
