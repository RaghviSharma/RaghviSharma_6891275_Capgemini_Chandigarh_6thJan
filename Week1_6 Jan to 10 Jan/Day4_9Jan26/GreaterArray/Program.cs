using System.Numerics;

namespace GreaterArray
{
    internal class Program
    {
        public void find()
        {
            Console.Write("Enter the size of 1st array:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the size of 2nd array");
            int x2= Convert.ToInt32(Console.ReadLine());
            int[] arr;
            if(x1<=0||x2<=0)
            {
                arr = new int[1];
                arr[0] = -2;
                Console.WriteLine("Output array is:" + arr[0]);
                return;
            }
            int[] arr1 = new int[x1];
            Console.WriteLine("Enter elements of 1st array:");
            for(int i=0;i<x1;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
			int[] arr2 = new int[x2];
			Console.WriteLine("Enter elements of 1st array:");
			for (int i = 0; i < x2; i++)
			{
				arr2[i] = Convert.ToInt32(Console.ReadLine());
			}
            for(int i=0;i< x1;i++)
            {
                if (arr1[i] < 0)
                {
					arr = new int[1];
					arr[0] = -1;
					Console.WriteLine("Output array is:" + arr[0]);
					return;
				}
            }
            for(int i=0;i< x2;i++)
            {
                if (arr2[i]<0)
                {
					arr = new int[1];
					arr[0] = -1;
					Console.WriteLine("Output array is:" + arr[0]);
					return;
				}
            }
            int size=Math.Max(x1,x2);
            arr = new int[size];
            for(int i=0;i< size;i++)
            {
                if (arr1[i] > arr2[i])
                    arr[i] = arr1[i];
                else
                    arr[i] = arr2[i];
            }
            Console.WriteLine("Output array is:");
            for(int i=0;i<size;i++)
            {
                Console.Write(arr[i]+" ");
            }


		}
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.find();
        }
    }
}
