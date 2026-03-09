using System;
using System.Collections.Generic;
using System.Text;

namespace Donation
{
    internal class UserProgramCode
    {
		public static int getDonation(string[] input1, int input2)
		{
			for(int i=0; i<input1.Length; i++)
			{
				for(int j=i+1;j<input1.Length; j++)
				{
					if (input1[i] == input1[j])
						return -1;
				}
			}
	       foreach(var i in input1)
			{
				foreach(char ch in i)
				{
					if(Char.IsLetterOrDigit(ch)==false)
					{
						return -2;
					}
				}
			}
			int sum = 0;
			foreach (var i in input1)
			{
				string usercode = i.Substring(0, 3);
				string location = i.Substring(3, 3);
				string donationAm = i.Substring(6, 3);
				if (location == input2.ToString())
				{
					sum += Convert.ToInt32(donationAm);
				}
			}
			return sum;
		}

	}
}
