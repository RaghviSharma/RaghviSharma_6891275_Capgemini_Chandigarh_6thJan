namespace Palindrome
{
    internal class Program
    {
        public int Check()
        {
            int output = 0;
            Console.Write("Enter the number u want to check:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            if (input1 < 0)
            {
                output = -1;
                return output;
            }
            int temp = input1;
            while (temp > 0)
            {
                int rem = temp % 10;
                output = output * 10 + rem;
                temp /= 10;
            }
            if (output == input1)
            {
                output = 1;
                return output;
            }
            return output = -2;
        }
                static void Main(string[] args)
                {
                    Program obj= new Program();
                    Console.WriteLine(obj.Check());
                }
    }
}
