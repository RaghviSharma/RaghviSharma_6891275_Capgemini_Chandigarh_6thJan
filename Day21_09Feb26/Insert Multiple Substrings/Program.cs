namespace Insert_Multiple_Substrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the original string:");
            string str=Console.ReadLine();
            Console.Write("Enter the number of substrings u want to add:");
            int n=Convert.ToInt32(Console.ReadLine());
            string ans = "";
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the substring to add:");
                string sub = Console.ReadLine();

                Console.WriteLine("Enter the specific location:");
                int loc = Convert.ToInt32(Console.ReadLine());
                ans = UserProgramCode.Insertion(str, sub, loc);
                str = ans;
            }
            Console.WriteLine(ans);
        }
    }
}
