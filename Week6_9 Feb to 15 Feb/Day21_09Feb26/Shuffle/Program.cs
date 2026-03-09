namespace UserProgramCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string z:");
            string z=Console.ReadLine();
            Console.Write("Enter the string x:");
            string x=Console.ReadLine();
            Console.Write("Enter the string y:");
            string y=Console.ReadLine();
            Console.WriteLine(UserProgramCode.perfectShuffle(z, x, y));
        }
    }
}
