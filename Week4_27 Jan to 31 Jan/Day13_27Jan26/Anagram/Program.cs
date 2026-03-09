namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string: ");
            string s1=Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string s2=Console.ReadLine();
            CheckAnagram obj= new CheckAnagram();
            Console.WriteLine(obj.check(s1, s2));
        }
    }
}
