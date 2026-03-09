using System;
using System.Collections.Generic;
using System.Text;

namespace AllAreAnagram
{
    internal class UserProgramCode
    {
        public static bool find(string[] input)
        {
            string a = input[0];
            char[] arr= a.ToCharArray();
            Array.Sort(arr);
             a = new string(arr);
            int i = 0;
            foreach(string s in input)
            {
				string x = input[i++];
				char[] arr2 = x.ToCharArray();
                Array.Sort(arr2);
				x = new string(arr2);
                if (x != a)
                    return false;
			}
            return true;
        }
    }
}
