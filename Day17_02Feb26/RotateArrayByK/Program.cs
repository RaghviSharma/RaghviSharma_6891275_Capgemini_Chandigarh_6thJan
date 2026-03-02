namespace RotateArrayByK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter number of steps for rotation: ");
            int k=Convert.ToInt32(Console.ReadLine());
            int[] ans = UserProgramCode.Rotation(arr, k);
            foreach(int i in ans)
            {
                Console.Write(i + " ");
            }
        }
    }
}
