using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Unique_Words
{
    internal class UserProgramCode
    {
        public static string Sort(string s)
        {
			string st = "";
			char[] arr = s.ToCharArray();
			Array.Sort(arr);
			foreach (char c in arr)
			{
				st += c;
			}
            return st;
		}
        public static string[] Unique(string[] input)
        {
            List<string> ans= new List<string>();
            Dictionary<string,List<string>> dt=new Dictionary<string,List<string>>();
            foreach(string str in input)
            {
                string sorted = Sort(str);
                if(!dt.ContainsKey(sorted))
                {
                    dt[sorted]=new List<string>();
                }
                dt[sorted].Add(str);
            }
            foreach(var (key,value) in dt)
            {
                if (value.Count==1)
                {
                    ans.Add(value[0]);
                }
            }
            return ans.ToArray();
        }
    }
}
