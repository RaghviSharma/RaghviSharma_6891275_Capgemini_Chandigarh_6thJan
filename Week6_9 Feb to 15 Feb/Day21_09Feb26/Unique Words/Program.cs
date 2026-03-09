namespace Unique_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "listen", "silent", "Hello", "World", "cba", "abc" };
            string[] ans = UserProgramCode.Unique(str);
            foreach (string s in ans)
            {
                Console.WriteLine(s);
            }
        }
    }
}
