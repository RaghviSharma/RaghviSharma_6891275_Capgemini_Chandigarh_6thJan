namespace Date_Extraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string date = Console.ReadLine();
            Console.WriteLine(UserProgramCode.extractDate(date));
        }
    }
}
