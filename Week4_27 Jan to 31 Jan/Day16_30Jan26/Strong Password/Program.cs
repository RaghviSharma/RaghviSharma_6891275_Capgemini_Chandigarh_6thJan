namespace Strong_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string input = Console.ReadLine();
            Console.WriteLine(UserProgramCode.check(input));
        }
    }
}
