using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumDeletion
{
    internal class UserProgramCode
    {
        public static int findSimilar(string input)
        {
            int duplicate = 0;
            int count = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    duplicate += count / 2;
                    count = 1;
                }
            }
            duplicate += count / 2;
            return duplicate;
        }
    }
}
