namespace ProductOfMaxNMin
{
    internal class Program
    {
        public int find()
        {
            int output = 0;
            Console.Write("Enter the size of array:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                output = -2;
                return output;
            }
            Console.WriteLine("Enter the elements of array:");
            int[] input1 = new int[input2];
            for (int i = 0; i < input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
                if (input1[i] < 0)
                {
                    output = -1;
                    return output;
                }
            }
            input1.Sort();
            output = input1[0] * input1[input2 - 1];
            return output;
        }
        static void Main(string[] args)
        {
            Program obj= new Program();
            Console.WriteLine(obj.find());
        }
    }
}
