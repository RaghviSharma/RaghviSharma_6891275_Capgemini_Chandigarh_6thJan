using System;
using System.Collections.Generic;
using System.Text;

namespace EligibleForVote
{
    internal class UserProgramCode
    {
        public static Boolean isEligible(int age)
        {
            if (age >= 18)
                return true;
            return false;
        }
    }
}
