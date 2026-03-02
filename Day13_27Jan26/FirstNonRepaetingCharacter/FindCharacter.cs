using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FirstNonRepaetingCharacter
{
    internal class FindCharacter
    {
        public void find(string str)
        {
            Dictionary<char,int > dict=new Dictionary<char,int >();
            foreach(char ch in str)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                    dict[ch]=1;
            }
            foreach(char ch in str)
            {
                if (dict[ch]==1)
                {
                    Console.WriteLine(ch);
                    break;
                }
            }
        }
    }
}
