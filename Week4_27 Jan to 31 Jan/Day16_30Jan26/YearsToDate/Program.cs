
namespace YearsToDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string input1 = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.addYear(input1, n));
            
        }
    }
}
