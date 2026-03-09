using System;
using System.Collections.Generic;
using System.Text;

namespace Count_of_Elements
{
    internal class UserProgramCode
    {
        public static int GetCount(string[] input1,char input2)
        {
            if (!Char.IsLetter(input2))
                return -3;
            int count = 0;
              foreach(string item in input1)
            {
                if (Char.ToLower(item[0])==Char.ToLower(input2))
                    count++;

            }
            if (count == 0)
                return -1;
              return count;
        }

	}
}
