namespace AllAreAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input=new string[n];
            for(int i=0;i<n;i++)
            {
                input[i] = Console.ReadLine();
            }
            Console.WriteLine(UserProgramCode.find(input));
        }
    }
}
