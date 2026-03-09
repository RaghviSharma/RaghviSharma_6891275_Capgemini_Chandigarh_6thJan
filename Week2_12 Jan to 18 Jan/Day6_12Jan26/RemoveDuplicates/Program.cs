namespace RemoveDuplicates
{
    internal class Program
    {
        public int[] check()
        {

            Console.Write("Enter the size of array:");
            int Input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements of array:");
            int[] input1 = new int[Input2];
            int[] output;
            for (int i = 0; i < Input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in input1)
            {
                if (i < 0)
                {
                    output = new int[1];
                    output[0] = -1;
                    return output;
                }
            }
            Array.Sort(input1);

            int k = 0;
            for (int j = k+1; j < Input2; j++)
            {
                if (input1[j] == input1[k])
                    j++;
                else
                {
                    k++;
                    input1[k] = input1[j];
                }
            }
            int[] res = new int[k + 1];

            for (int i = 0; i <= k; i++)
            {
                res[i] = input1[i];
            }
            return res;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int[] output = obj.check();
            foreach (int i in output)
            {
                Console.Write(i + " ");
            }
        }
    }
}


