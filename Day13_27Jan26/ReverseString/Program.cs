namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reverse obj=new Reverse();
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            obj.rev(str);
        }
    }
}
