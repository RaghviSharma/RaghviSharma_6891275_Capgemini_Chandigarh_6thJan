namespace Couple_And_Triplet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array:");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            int[] arr=new int[n];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(UserProgramCode.FinalScore(arr));
        }
    }
}
