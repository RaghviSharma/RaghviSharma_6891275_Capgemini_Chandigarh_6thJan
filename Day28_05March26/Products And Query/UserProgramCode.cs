using System;
using System.Collections.Generic;
using System.Text;

namespace Products_And_Query
{
    internal class UserProgramCode
    {
		public static List<List<string>> getMatchingProducts(List<List<string>> products, List<List<string>> queries)
		{

			List<List<string>> result= new List<List<string>>();
			foreach(var q in queries)
			{
				string type = q[0];
				string val = q[1];
				List<string> temp= new List<string>();
				foreach(var p in products)
				{
					string name = p[0];
					int price = Convert.ToInt32(p[1]);
					int year = Convert.ToInt32(p[2]);
					if(type=="Type1"&&year==int.Parse(val))
					{
						temp.Add(name);
					}
					else if(type=="Type2"&&price<int.Parse(val))
					{
						temp.Add(name);
					}
					else if(type=="Type3"&&price>int.Parse(val))
					{
						temp.Add(name);
					}
				}
				result.Add(temp);

			}
			return result;


		}
	}
}
