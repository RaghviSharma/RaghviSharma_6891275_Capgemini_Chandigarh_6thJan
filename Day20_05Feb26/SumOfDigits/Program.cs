namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the digit:");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.FindSum(n));
        }
    }
}
