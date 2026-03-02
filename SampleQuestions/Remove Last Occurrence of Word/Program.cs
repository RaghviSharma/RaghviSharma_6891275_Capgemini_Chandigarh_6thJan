namespace Remove_Last_Occurrence_of_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string remove= Console.ReadLine();
            Console.Write(UserProgramCode.Remove(s, remove));
        }
    }
}
