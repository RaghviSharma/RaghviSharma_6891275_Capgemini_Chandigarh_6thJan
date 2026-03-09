namespace DateFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date: ");
            string date = Console.ReadLine();
            Console.WriteLine("Enter number of years to add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.findDay(date, num));
        }
    }
}
