namespace Electricity_Bill_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first input: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second input: ");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter the rate per unit ");
            int input3= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.Calculate(input1, input2, input3));

		}
    }
}
