namespace AscendingDesc
{
    internal class Program
    {
        public int[] sorting()
        {
            Console.Write("Enter the size of array:");
            int input2=Convert.ToInt32(Console.ReadLine());
            if(input2<0)
            {
                return [-1];
            }
            int[] input1 = new int[input2];
            for (int i = 0; i < input1.Length; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int mid = input2 / 2;
            Array.Sort(input1, 0, input2-1);
            Array.Reverse(input1, mid , input2 - mid);
            return input1;
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            int[] output=obj.sorting();
            foreach (int i in output)
            {
                Console.Write(i+" ");
            }
        }
    }
}
