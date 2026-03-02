namespace RemoveAndSort
{
    internal class Program
    {
        public int[] find()
        {
            int[] output;
            Console.Write("Enter the size of array:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                output = new int[1];
                output[0] = -2;
                return output;
            }
            int[] input1 = new int[input2];
            Console.WriteLine("Enter the elements of array:");
            for (int i = 0; i < input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
                if (input1[i] < 0)
                {
                    output = new int[1];
                    output[0] = -1;
                    return output;
                }
            }
            Console.Write("Enter the element u want to remove");
            int input3 = Convert.ToInt32(Console.ReadLine());
            output = new int[input2];
            int k = 0;
            bool isFind = false;
            foreach (int i in input1)
            {
                if (i != input3)
                {
                    output[k++] = i;
                }
                else
                    isFind = true;
            }
            if (isFind == false)
            {
                output = new int[1];
                output[0] = -3;
                return output;
            }

            Array.Resize(ref output, k);
            Array.Sort(output);
            return output;
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            int[] output = obj.find();
            foreach(int i in output)
            {
                Console.Write(i + " ");
            }
        }
    }
}
