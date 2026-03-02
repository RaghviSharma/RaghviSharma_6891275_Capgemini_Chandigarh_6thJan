namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Palindromic obj=new Palindromic();
            Console.WriteLine(obj.check(str));
        }
    }
}
