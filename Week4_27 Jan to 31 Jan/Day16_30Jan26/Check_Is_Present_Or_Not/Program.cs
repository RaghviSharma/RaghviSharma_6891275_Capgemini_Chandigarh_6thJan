namespace Check_Is_Present_Or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the main string: ");
            string input1=Console.ReadLine();
            Console.WriteLine("Enter other two strings");
            string input2=Console.ReadLine();
            string input3=Console.ReadLine();
            Console.WriteLine(UserProgramCode.IsPresent(input1, input2, input3));
        }
    }
}
