namespace Maximum_Consecutive_pair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string:");
            string str=Console.ReadLine();
            Console.WriteLine(UserProgramCode.FindConsec(str));
        }
    }
}
