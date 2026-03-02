using System.Xml;

namespace RemoveDuplicates
{
    internal class Program
    {
        public int[] check()
        {
            int[] result;
            Console.WriteLine("Enter the size of array:");
            int Input2 = Convert.ToInt32(Console.ReadLine());
            if (Input2 < 0)
            {
                result = new int[1];
                result[0] = -2;
                return result;
            }
            Console.WriteLine("Enter elements of array:");
            int[] input1 = new int[Input2];
            for (int i = 0; i < Input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in input1)
            {
                if (i < 0)
                {
                    result = new int[1];
                    result[0] = -1;
                    return result;
                }
            }
            result = new int[Input2];
            int k = 0;
            for (int i = 0; i < Input2; i++)
            {
				bool isDuplicate = false;
                for (int j = 0; j < k; j++)
                {
                    if (input1[i] == result[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                    if(!isDuplicate)
                    {
                        result[k] = input1[i];
                        k++;
                    }
                }
            
            int[] output = new int[k];
            for (int i = 0; i < k; i++)
            {
                output[i] = result[i];
            }
            return output;
        }
        static void Main(string[] args)
        {
            Program obj= new Program();
            int[] output1 = obj.check();
            foreach(int i in  output1)
            {
                Console.Write(i + " ");
            }

        }
    }
}
