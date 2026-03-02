namespace MaximumDeletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string input = Console.ReadLine();
            Console.WriteLine(UserProgramCode.findSimilar(input));
        }
    }
}
