using System.Numerics;

namespace MultiplyArray
{
    internal class Program
    {
        public void multiply()
        {
            Console.Write("Enter size of array:");
            int x = Convert.ToInt32(Console.ReadLine());
            int ans = 1;
            if (x < 0)
            {
                ans = -2;
                Console.WriteLine("Answer is:"+ans);
                return;
            }
            int[] arr=new int[x];
            Console.WriteLine("Enter elements of array:");
            for(int i=0;i<x;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<x;i++)
            {
                if (arr[i]>0)
                {
                    ans=ans*arr[i];
                }
            }
            Console.WriteLine("Answer is:"+ans);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.multiply();
        }
    }
}
