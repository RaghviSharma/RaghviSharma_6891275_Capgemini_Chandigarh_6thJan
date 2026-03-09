using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ScoringSystem
{
    internal class ValidCalculation
    {
        public void checkIsValid(int X,int Y,int n1,int n2,int M)
        {
            for(int i=1;i<n2;i++)
            {
                for(int j=1;j<n1;j++)
                {
                    if(X*j+Y*i==M)
                    {
                        Console.WriteLine("Valid");
                        Console.WriteLine(j);
                        Console.WriteLine(i);
                        return;
                    }
                   
                }
            }
            Console.WriteLine("invalid");
        }
    }
}
