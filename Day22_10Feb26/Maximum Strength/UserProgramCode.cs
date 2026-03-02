using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum_Strength
{
    internal class UserProgramCode
    {
        public static int FindStrength(int[] skill, int[] teamSize)
        {
            Array.Sort(skill);
            Array.Sort(teamSize);
            //12 3 8 16 10 4   //3 4 8 10 12 16
            //3 3
            int strength = 0;
            int left = 0;
            int right=skill.Length-1;
            strength += skill[left++] + skill[right--];

        }
    }
}
