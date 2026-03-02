using System.Text.RegularExpressions;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "raghvi29sharma@gmail.com";
            string pattern = @"[a-z]\d{2}@\.";
            bool ans = Regex.IsMatch(input, pattern);
            Console.WriteLine(ans);
        }
    }
}
