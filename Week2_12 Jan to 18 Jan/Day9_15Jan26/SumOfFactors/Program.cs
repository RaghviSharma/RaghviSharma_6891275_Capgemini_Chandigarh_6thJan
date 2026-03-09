using System.Xml;

namespace SumOfFactors
{
    internal class Program
    {
        public int find()
        {
            int output = 0;
            Console.Write("Enter the first input:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            if (input1 < 0)
            {
                output = -1;
                return output;
            }
            Console.Write("Enter the second input:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 > 32627)
            {
                output = -2;
                return output;
            }
            for (int i = input1; i <= input2; i++)
            {
                if (i % input1 == 0)
                {
                    output += i;
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
           Program obj= new Program();
            Console.Write(obj.find());
        }
    }
}
