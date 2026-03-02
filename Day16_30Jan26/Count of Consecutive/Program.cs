namespace Count_of_Consecutive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string input1=Console.ReadLine();
            Console.WriteLine(UserProgramCode.findCount(input1));
        }
    }
}
