namespace Duplicate_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 4, 3, 2, 5, 1, 2 };
            int[] ans = UserProgramCode.res(arr);
            foreach(int i in ans)
            {
                Console.Write(i + " ");
            }
        }
    }
}
