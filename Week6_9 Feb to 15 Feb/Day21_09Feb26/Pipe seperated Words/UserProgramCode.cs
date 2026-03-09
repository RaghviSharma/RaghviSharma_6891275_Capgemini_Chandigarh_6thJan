using System;
using System.Collections.Generic;
using System.Text;

namespace Pipe_seperated_Words
{
    internal class UserProgramCode
    {
        public static string Reverse(string input)
        {
            string ans = "";
            string[] arr = input.Split('|');
            Array.Reverse(arr);
            ans = string.Join(" ", arr);
            return ans;
        }
    }
}
