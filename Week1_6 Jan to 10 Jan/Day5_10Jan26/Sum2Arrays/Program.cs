using System.Xml;

namespace Sum2Arrays
{
    internal class Program
    {
        public int[] Check()
        {
            Console.WriteLine("Enter the size of arrays:");
            int Input3 = Convert.ToInt32(Console.ReadLine());
            int[] result;
            if (Input3 < 0)
            {
                result = new int[1];
                result[0] = -2;
                return result;
            }
            Console.WriteLine("Enter elements of first array:");
            int[] Input1 = new int[Input3];
            for (int i = 0; i < Input3; i++)
            {
                Input1[i] = Convert.ToInt32(Console.ReadLine());
            }
			Console.WriteLine("Enter elements of first array:");
			int[] Input2 = new int[Input3];
            for (int i = 0; i < Input3; i++)
            {
                Input2[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in Input1)
            {
                if (i < 0)
                {
                    result = new int[1];
                    result[0] = -1;
                    return result;
                }
            }
            foreach (int i in Input2)
            {
                if (i < 0)
                {
                    result = new int[1];
                    result[0] = -1;
                    return result;
                }
            }
            result = new int[Input3];
            for (int i = 0; i < Input3; i++)
            {
                result[i] = Input1[i] + Input2[Input3 - i - 1];
            }
            return result;
        }

            static void Main(string[] args)
            {
                Program obj= new Program();
                int[] output = obj.Check();
                foreach(int i in output)
                {
                    Console.Write(i + " ");
                }
            }
        }
   }


