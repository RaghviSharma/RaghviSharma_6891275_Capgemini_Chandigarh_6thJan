using System;

namespace ValidTimeFormatCaseStudy1
{
	internal class FindValidFormat
	{
		public int find(string str)
		{
			if (str.Length != 8)
				return -1;
			if (str[2] != ':')
				return -1;

			int hr = Convert.ToInt32(str.Substring(0, 2));
			int min = Convert.ToInt32(str.Substring(3, 2));
			string left = str.Substring(5, 3);
			if (hr < 1 || hr > 12)
				return -1;

			if (min < 0 || min >= 60)
				return -1;

			if (left != " am" && left != " pm")
				return -1;

			return 1;
		}
	}
}
