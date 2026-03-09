namespace CheckParanthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            ValidParenthesis obj= new ValidParenthesis();
            Console.WriteLine(obj.check(str));
        }
    }
}
