namespace Product_Sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr= new string[n];
            Console.WriteLine("Enter the elements of array:");
            for(int i=0;i<n;i++)
            {
                arr[i] = Console.ReadLine();
            }
        }
    }
}
