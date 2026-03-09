namespace SearchInArray
{
    internal class Program
    {
        public int find()
        {
            int output = 1;
            Console.WriteLine("Enter the size of array:");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x<0)
            {
                output = -2;
                return output;
            }
            Console.WriteLine("Enter the elements of array:");
            int[] arr = new int[x];
            for(int i=0;i<x;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<x;i++)
            {
                if (arr[i]<0)
                {
                    output = -1;
                    return output;
                }
            }
            Console.WriteLine("Enter the element u want to search:");
            int find = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<x;i++)
            {
                if (arr[i] == find)
                {
                    output = i;
                    return output;
                }
            }
            return output;

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.find());
        }
    }
}
