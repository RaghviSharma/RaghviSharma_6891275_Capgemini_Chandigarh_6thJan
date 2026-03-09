using System.Xml;

namespace MultiplesOf3
{
    internal class Program
    {
        public int count()
        {
            int output = 0;
            Console.WriteLine("Enter the size of array:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements of array:");
            int[] input1 = new int[input2];
            for (int i = 0; i < input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in input1)
            {
                if (i < 0)
                {
                    output = -1;
                    return output;
                }
            }
            int count = 0;
            for (int i = 0; i < input2; i++)
            {
                if (input1[i] % 3 == 0)
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
            Console.WriteLine(obj.count());
        }
    }
}
