namespace CounTargetEle
{
    internal class Program
    {
        public int search()
        {
            int output = 0;
            Console.WriteLine("Enter the size of array:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                output = -2;
                return output;
            }
            int[] input1 = new int[input2];
            Console.WriteLine("Enter the elements of array:");
            for (int i = 0; i < input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
                if (input1[i] < 0)
                {
                    output = -1;
                    return output;
                }
            }
            Console.WriteLine("Enter the value u want to search:");
            int input3 = Convert.ToInt32(Console.ReadLine());
            if (input3 < 0)
            {
                output = -3;
                return output;
            }
            int count = 0;
            foreach (int i in input1)
            {
                if (i == input3)
                {
                    count++;
                }
            }
            output = count;
            return output;
        }

        static void Main(string[] args)
        {
            Program obj= new Program();
            Console.WriteLine(obj.search());
        }
    }
}
