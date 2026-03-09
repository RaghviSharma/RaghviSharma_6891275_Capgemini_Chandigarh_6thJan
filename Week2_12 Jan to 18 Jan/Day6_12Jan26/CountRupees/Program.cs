using System;

namespace CountRupees
{
    internal class Program
    {
        public int find()
        {
            Console.Write("Enter the number:");
            int input = Convert.ToInt32(Console.ReadLine());
            int output = 0;
			while (input > 0)
			{
				if (input >= 500)
				{
					int rem = input/ 500;
					input -= rem*500;
					output += rem;
				}
				else if (input >= 100)
				{
					int rem = input / 100;
					input -= rem*100;
					output += rem;
				}
				else if (input >= 50)
				{
					int rem = input / 50;
					input -= rem*50;
					output += rem;
				}
				else if (input >= 10)
				{
					int rem = input / 10;
					input -= rem * 10;
					output += rem;
				}
				else if (input >= 1)
				{
					int rem = input / 1;
					input -= rem * 1;
					output += rem;
				}
			}
				return output;
			}
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.Write(obj.find());
        }
    }
}
