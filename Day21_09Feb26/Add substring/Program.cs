namespace Add_substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string:");
            string str=Console.ReadLine();
            Console.Write("Enter the substring to add:");
            string s=Console.ReadLine();
            Console.Write("Enter the location:");
            int loc=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.InsertAtLoc(str,s,loc));
        }
    }
}
