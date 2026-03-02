using System;
using System.Collections.Generic;
using System.Text;

namespace Closest_square
{
    internal class UserProgramCode
    {
        public static Boolean find(int input)
        {
            int root = (int)Math.Sqrt(input);
            if (root * root == input)
                return true;
            return false;
        }
        public static int checkSq(int input)
        {
           
            if (find(input))
                return input;
            else
            {
				int temp = input;
                while (!find(temp))
                {

                    temp--;
                }
               int temp1 = input - temp;
                temp = input;
                while (!find(temp))
                    temp++;
              int temp2 = temp-input;
                if (temp1 < temp2)
                {
                    return input-temp1;
                }
                else
                    return temp2 + input;
            }
        }
    }
}
