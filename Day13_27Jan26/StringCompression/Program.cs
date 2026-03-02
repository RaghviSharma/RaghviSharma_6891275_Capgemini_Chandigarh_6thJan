namespace StringCompression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            CountCompressed obj= new CountCompressed();
            Console.WriteLine(obj.compress(str));
        }
    }
}
