namespace Replace_first_occurrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            char ch = Convert.ToChar(Console.ReadLine());
            char newC=Convert.ToChar(Console.ReadLine());
            Console.Write(UserProgramCode.ReplaceC(str, ch,newC));
        }
    }
}
