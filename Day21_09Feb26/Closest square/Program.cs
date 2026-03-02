namespace Closest_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(UserProgramCode.checkSq(input));
        }
    }
}
