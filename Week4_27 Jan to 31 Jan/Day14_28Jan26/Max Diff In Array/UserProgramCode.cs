using System;
using System.Collections.Generic;
using System.Text;

namespace Max_Diff_In_Array
{
    internal class UserProgramCode
    {
		public static int diffIntArray(int[] input1)
		{
			foreach (int i in input1)
			{
				if (i < 0)
					return -1;
				if (input1.Length <= 1 || input1.Length > 10)
					return -2;
			}
			for (int i = 0; i < input1.Length; i++)
			{
				for (int j = i + 1; j < input1.Length; j++)
				{
					if (input1[i] == input1[j])
						return -3;
				}
			}
			int maxDiff = int.MinValue;
			for(int i=0;i< input1.Length; i++)
			{
				for( int j = i + 1;j < input1.Length; j++)
				{
					if (input1[i] < input1[j])
					{
						int diff = input1[j] - input1[i];
						if (diff > maxDiff)
						{
							maxDiff = diff;
						}
					}
				}
			}
			return maxDiff;
		}

	}
}
