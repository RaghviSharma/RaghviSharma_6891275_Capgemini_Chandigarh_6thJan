namespace SortArray
{
    internal class Program
    {
        public void Sorting()
        {
            Console.WriteLine("Enter size of first array:");
            int x1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter size of second array:");
			int x2 = Convert.ToInt32(Console.ReadLine());
			int[] arr;
            if (x1 <= 0 || x2 <= 0)
            {
                arr = new int[1];
                arr[0] = -2;
                Console.Write("Output array is:" + arr[0]);
                return;
            }
			int size = Math.Min(x1, x2);
			arr = new int[size];

            int[] arr1 = new int[x1];
            int[] arr2 = new int[x2];
            Console.WriteLine("Elements of first array are:");
            for(int i=0;i<x1;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
			Console.WriteLine("Elements of second array are:");
			for (int i = 0; i < x2; i++)
			{
				arr2[i] = Convert.ToInt32(Console.ReadLine());
			}
			for (int i = 0; i <x1; i++)
			{
                if (arr1[i] < 0)
                {
                    arr[0] = -1;
                    Console.Write("Output array is:" + arr[0]);
                    return;
                }


				}
			for (int i = 0; i < x2; i++)
			{
                if (arr2[i] < 0)
                {
                    arr[0] = -1;
                    Console.Write("Output array is:" + arr[0]);
                    return;
                }
				}

			for (int i=0;i<x1;i++)
            {
                for(int j=i+1;j<x1;j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        int temp = arr1[i];
						arr1[i] = arr1[j];
                        arr1[j] = temp;
					}
                        
                }
            }
  
            for(int i=0;i<x2;i++)
            {
                for(int j=i+1;j<x2;j++)
                {
                    if (arr2[i] <arr2[j])
                    {
                        int temp = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = temp;
                    }
                }
            }
            
            for(int i=0;i<size;i++)
            {
                
                    arr[i] = arr1[i] * arr2[x2-i-1];
                
            }
            Console.WriteLine("Output array is :");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
            }

		}
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.Sorting();
        }
    }
}
