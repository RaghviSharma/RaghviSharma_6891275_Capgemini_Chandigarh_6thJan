using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_filter_query
{
    internal class UserProgramCode
    {
		public static List<List<string>> getMatchingEmployees(List<List<string>> employees, List<List<string>> queries)
		{

			List<List<string>> result= new List<List<string>>();
			foreach (var q in queries)
			{
				string type = q[0].ToLower();
				string value = q[1];
				List<string> temp= new List<string>();
				foreach (var e in employees)
				{
					string name = e[0];
					int salary = int.Parse(e[1]);
					int experience = int.Parse(e[2]);
					string department = e[3];
					if (type == "type1" && salary > int.Parse(value))
					{
						temp.Add(name);
					}
					else if (type == "type2" && experience > int.Parse(value))
					{
						temp.Add(name);
					}
					else if (type == "type3" && department == value)
					{
						temp.Add(name);
					}
					else if (type == "type4")
					{
						var range = value.Split(' ');
						int min = int.Parse(range[0]);
						int max = int.Parse(range[1]);
						if (salary>= min && salary <= max)
						{
							temp.Add(name);
						}
					}
				}
				result.Add(temp);

			}
			return result;
		}
	}
}
