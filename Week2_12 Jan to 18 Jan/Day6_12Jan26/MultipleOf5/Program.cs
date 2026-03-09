namespace MultipleOf5
{
    internal class Program
    {
        public double check()
        {
            double output = 0;
            Console.Write("Enter the size of array:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                output = -2;
                return output;
            }
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
            double sum = 0;
            int count = 0;
            foreach (int i in input1)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                    count++;
                }
            }
            output = sum / count;
            return output;
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            Console.Write(obj.check());
        }
    }
}
