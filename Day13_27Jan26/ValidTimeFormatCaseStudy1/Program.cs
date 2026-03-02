namespace ValidTimeFormatCaseStudy1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time: ");
            string str = Console.ReadLine();
            FindValidFormat obj= new FindValidFormat();
            if (obj.find(str) == 1)
            {
                Console.WriteLine("Valid Time Format");
            }
            else
            {
                Console.WriteLine("Invalid Time Format");
            }
        }
    }
}
