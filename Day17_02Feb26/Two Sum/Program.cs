namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums= new int[n];
            for(int i=0;i<n;i++)
            {
                nums[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the target :");
            int target=Convert.ToInt32(Console.ReadLine());
            int[] ans = UserProgramCode.twoSum(nums, target);
            foreach(int i in ans)
            {
                Console.Write(i + " ");
            }
        }
    }
}
