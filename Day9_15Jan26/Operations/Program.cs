namespace Operations
{
    internal class Program
    {
        public int performOperation()
        {
            int output = 0;
            Console.Write("Enter the first element:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second element:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input1 < 0 || input2 < 0)
            {
                output = -1;
                return output;
            }
            Console.Write("Enter the number to perform operations between 1 to 4:");
            int input3 = Convert.ToInt32(Console.ReadLine());
            switch (input3)
            {
                case 1:
                    output = input1 + input2;
                    break;
                case 2:
                    output = input1 - input2;
                    break;
                case 3:
                    output = input1 * input3;
                    break;
                case 4:
                    output = input1 / input2;
                    break;
                default:
                    output = 0;
                    break;
            }
            return output;
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            Console.Write(obj.performOperation());
        }
    }
}
