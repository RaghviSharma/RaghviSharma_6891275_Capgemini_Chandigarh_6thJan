namespace Pipe_seperated_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pipe seperated string:");
            string str=Console.ReadLine();
            Console.WriteLine(UserProgramCode.Reverse(str));
        }
    }
}
