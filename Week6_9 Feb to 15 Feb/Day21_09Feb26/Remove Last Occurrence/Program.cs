namespace Remove_Last_Occurrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the word u want to remove:");
            string word=Console.ReadLine();
            Console.WriteLine(UserProgramCode.Remove(str, word));
        }
    }
}
