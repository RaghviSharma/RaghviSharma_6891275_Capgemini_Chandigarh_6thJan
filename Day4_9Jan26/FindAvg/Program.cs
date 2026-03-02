namespace FindAvg
{
    internal class Program
    {
        public int check()
        {
            int output = 0;
            int oddS = 0;
            int evenS = 0;
            Console.WriteLine("Enter the size of array:");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            Console.WriteLine("Enter elements of array:");
            for(int i=0;i<x;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (x < 0)
                output = -2;
            for(int i=0;i<x;i++)
            {
                if (arr[i]<0)
                    output = -1;
                break;
            }
            foreach(int i in arr)
            {
                if (i % 2 == 0)
                    evenS += i;
                else
                    oddS+= i;
            }
            int avg = (evenS + oddS) / 2;
            output = avg;
            return output;
        }
        static void Main(string[] args)
        {
            Program obj= new Program();
            Console.WriteLine(obj.check());
        }
    }
}
