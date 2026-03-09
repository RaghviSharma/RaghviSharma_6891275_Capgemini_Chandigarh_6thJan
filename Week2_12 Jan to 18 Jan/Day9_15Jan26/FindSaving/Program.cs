namespace FindSaving
{
    internal class Program
    {
        public double find()
        {
            double output1 = 0;
            Console.Write("Enter the total salary of the person:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            if(input1>9000)
            {
                output1 = -1;
                return output1;
            }
            Console.Write("Enter the number of working days :");
            int input2= Convert.ToInt32(Console.ReadLine());
            if(input2<0)
            {
                output1 = -4;
                return output1;
            }
            if(input2==31)
            {
                input1 += 500;
            }
            double total_expenses = (0.5 * input1) + (0.2 * input1);
            output1 = input1 - total_expenses;
            return output1;
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            Console.WriteLine(obj.find());
        }
    }
}
