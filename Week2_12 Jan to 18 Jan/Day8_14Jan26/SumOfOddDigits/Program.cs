namespace SumOfOddDigits
{
    internal class Program
    {
        public int sum()
        {
            int output = 0;
            Console.Write("Enter the number:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            if (input1 < 0)
            {
                output = -1;
                return output;
            }
            int temp = input1;
            while (temp != 0)
            {
                int digit = temp % 10;
                if (digit % 2 != 0)
                {
                    output += (int)Math.Pow(digit, 3);
                }
                temp /= 10;
            }
            return output;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.sum());
        }
    }
}
