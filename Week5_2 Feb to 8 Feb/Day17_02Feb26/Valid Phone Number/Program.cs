namespace Valid_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the mobile numbers: ");
            string number = Console.ReadLine();
            Console.WriteLine(UserProgramCode.Number(number));
        }
    }
}
