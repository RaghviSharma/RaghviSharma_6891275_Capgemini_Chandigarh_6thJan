namespace Remove_And_Insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string:");
            string str=Console.ReadLine();
            Console.Write("Enter the string to delete:");
            string s=Console.ReadLine();
            Console.Write("Enter the new substring:");
            string newS=Console.ReadLine();
            Console.WriteLine(UserProgramCode.InsertAndDelete(str, s, newS));
        }
    }
}
