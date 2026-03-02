namespace All_Words_Unique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "listen", "silent", "hello", "world", "abc", "cba" };
            string[] ans=UserProgramCode.FindUnique(arr);
            foreach(string s in ans)
            {
                Console.Write(s+" ");
            }
        }
    }
}
