namespace Sum_Largest_No_In_Range_CS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for(int i=0;i<size;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            SumLargest obj=new SumLargest();
            Console.WriteLine(obj.find(arr));
        }
    }
}
