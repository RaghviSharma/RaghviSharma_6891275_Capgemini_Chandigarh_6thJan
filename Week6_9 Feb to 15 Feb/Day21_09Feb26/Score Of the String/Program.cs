namespace Score_Of_the_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string:");
            string input=Console.ReadLine();
            Console.WriteLine(UserProgramCode.FindScore(input));

        }
    }
}
