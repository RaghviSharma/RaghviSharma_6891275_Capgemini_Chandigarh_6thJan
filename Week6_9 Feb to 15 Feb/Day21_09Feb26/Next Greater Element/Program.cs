namespace Next_Greater_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements of array:");
            int[] arr= new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(UserProgramCode.FindCount(arr));
        }
    }
}
