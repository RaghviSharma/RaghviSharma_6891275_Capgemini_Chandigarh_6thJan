namespace Valid_Email_Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the email address as a string: ");
            string mail = Console.ReadLine();
            Console.WriteLine(UserProgramCode.Validation(mail));
        }
    }
}
