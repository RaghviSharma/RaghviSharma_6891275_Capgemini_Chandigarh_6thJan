namespace Remove_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(UserProgramCode.removeDup(arr));
            //int[] ans = UserProgramCode.removeDup(arr);
            //foreach (int i in ans)
            //{
            //    Console.WriteLine(i + " ");
            //}
        }
    }
}
