namespace RomanToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in roman: ");
            string s=Console.ReadLine();
            Console.WriteLine(UserProgramCode.convertRomanToDecimal(s));
        }
    }
}
