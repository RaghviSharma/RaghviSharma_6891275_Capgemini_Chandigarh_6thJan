using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    internal class CheckAnagram
    {
        public Boolean check(string s1,string s2)
        {
            char[] temp1 = s1.ToCharArray();
            char[] temp2 = s2.ToCharArray();

            temp1.Sort();
            temp2.Sort();

            s1 = new string(temp1);
            s2 = new string(temp2);
            if(s1==s2)
                return true;
            return false;

            
        }
    }
}
