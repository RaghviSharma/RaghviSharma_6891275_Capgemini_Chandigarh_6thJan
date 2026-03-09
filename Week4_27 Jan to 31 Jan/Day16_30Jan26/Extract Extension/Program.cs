namespace Extract_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input1=Console.ReadLine();
            Console.WriteLine(UserProgramCode.extract(input1));
        }
    }
}
