using System;
using System.Collections.Generic;
using System.Text;

namespace Couple_And_Triplet
{
    internal class UserProgramCode
    {
        public static int FinalScore(int[] arr)
        {
            int score = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if ((arr[i] + arr[i - 1]) % 2 == 0)
                    score = score + 5;
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (((arr[i] + arr[i - 1] + arr[i - 2]) % 2 != 0) && (arr[i] * arr[i - 1] * arr[i - 2]) % 2 == 0)
                    score = score + 10;
            }
            return score;
        }
    }
}
