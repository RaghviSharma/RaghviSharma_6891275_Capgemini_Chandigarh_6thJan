namespace Insert_A_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string:");
            string str=Console.ReadLine();
            Console.Write("Enter the specific character:");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the specific location:");
            int loc=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.InsertChar(str, ch, loc));
        }
    }
}
