using System;
using System.Collections.Generic;
using System.Text;

namespace All_Words_Unique
{
    internal class UserProgramCode
    {
        public static string[] FindUnique(string[] arr)
        {
            Dictionary<string, List<string>> dt = new Dictionary<string, List<string>>();
            List<string> ans = new List<string>();
            foreach (string s in arr)
            {
                char[] check = s.ToCharArray();
                Array.Sort(check);
                string use = new string(check);

                if (!dt.ContainsKey(use))
                {
                    dt[use] = new List<string>();
                }
                dt[use].Add(s);
            }
            foreach (var (key, value) in dt)
            {
                if (value.Count == 1)
                {
                    ans.Add(value[0]);
                }
            }
            return ans.ToArray();
        }
    }
}
