namespace Donation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in string array:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input1= new string[n];
            for(int i = 0; i < n;i++)
            {
                input1[i] = Console.ReadLine();
            }
            Console.Write("Enter the location code: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.getDonation(input1, input2));
        }
    }
}
