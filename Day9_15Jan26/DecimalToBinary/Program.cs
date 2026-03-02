namespace DecimalToBinary
{
    internal class Program
    {
        public int[] convert()
        {
            Console.Write("Enter the value in decimal:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            if (input1 < 0)
            {
                return [-1];
            }
            int temp = input1;
            int length = 0;
            while (temp > 0)
            {
                length++;
                temp = temp / 2;
            }
            int[] res = new int[length];
            temp = input1;
            int i = length - 1;
            while (temp > 0)
            {
                int rem = temp % 2;
                res[i--] = rem;
                temp = temp / 2;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int[] output = obj.convert();
            foreach (int i in output)
            {
                Console.Write(i + " ");

            }
        }
    }
}
