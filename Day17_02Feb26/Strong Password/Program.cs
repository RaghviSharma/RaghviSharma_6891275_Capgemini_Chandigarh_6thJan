namespace Strong_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();
            Console.WriteLine(UserProgramCode.checkPswrd(password));
        }
    }
}
