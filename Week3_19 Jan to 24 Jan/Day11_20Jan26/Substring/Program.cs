namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of substring:");
           int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the string:");
            string str=Console.ReadLine();
            checkvalid obj = new checkvalid();
            obj.find(n, str);

        }
    }
}
