namespace FindSumOfPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array:");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(UserProgramCode.find(arr, n));
        }
    }
}
