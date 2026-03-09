namespace DistinctCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string s=Console.ReadLine();
            Console.WriteLine(UserProgramCode.findDistinct(s));
        }
    }
}
