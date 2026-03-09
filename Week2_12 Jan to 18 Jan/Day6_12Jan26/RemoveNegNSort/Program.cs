namespace RemoveNegNSort
{
    internal class Program
    {
        public int[] check()
        {
            Console.Write("Enter the size of array:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                return new int[] { -1 };
            }
            Console.WriteLine("Enter the elements of array:");
            int count = 0;
            int[] input1 = new int[input2];
            for (int i = 0; i < input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
                if (input1[i] >= 0)
                    count++;
            }
            int[] output = new int[count];
            int k = 0;
            foreach (int i in input1)
            {
                if (i >= 0)
                {
                    output[k++] = i;
                }
            }
            output.Sort();
            
            return output;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            var output1 = obj.check();
            foreach(int i in output1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
