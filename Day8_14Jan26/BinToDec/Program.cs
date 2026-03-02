namespace BinToDec
{
    internal class Program
    {
        public int convert()
        {
            int output = 0;
            Console.Write("Enter the input:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int temp = input1;
            while (temp != 0)
            {
                int rem = temp % 10;
                if (rem != 0 && rem != 1)
                {
                    output = -1;
                    return output;
                }
                temp = temp / 10;
            }
            if (input1 > 11111)
            {
                output = -2;
                return output;
            }
            temp = input1;
            int i = 0;
            while (temp != 0)
            {
                int rem = temp % 10;
                output += rem * (int)Math.Pow(2, i);
                i++;
                temp = temp / 10;
            }
            return output;
        }

        static void Main(string[] args)
        {
            Program obj= new Program();
            Console.Write(obj.convert());
            
        }
    }
}
