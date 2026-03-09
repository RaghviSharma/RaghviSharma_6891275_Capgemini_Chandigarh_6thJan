namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.findSum(n));
        }
    }
}
