namespace Replace_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string:");
            string str=Console.ReadLine();
            Console.Write("Enter the character:");
            char ch=Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the new character:");
            char newCh=Convert.ToChar(Console.ReadLine());

            Console.WriteLine(UserProgramCode.Replace(str, ch, newCh));
        }
    }
}
