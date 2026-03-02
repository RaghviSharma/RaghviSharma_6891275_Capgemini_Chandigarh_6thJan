namespace Sort_Pipe_seperated_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string in pipe seperated form:");
            string str = Console.ReadLine();
            Console.WriteLine(UserProgramCode.findWords(str));
        }
    }
}
