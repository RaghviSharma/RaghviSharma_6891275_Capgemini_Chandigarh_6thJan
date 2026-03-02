namespace DifferenceBetweenDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first date:");
            string date1=Console.ReadLine();
            string date2=Console.ReadLine();
            Console.WriteLine(UserProgramCode.difference(date1,date2));
        }
    }
}
