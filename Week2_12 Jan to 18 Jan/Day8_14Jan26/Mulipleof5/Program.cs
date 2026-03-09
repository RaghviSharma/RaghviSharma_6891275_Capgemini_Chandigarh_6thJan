namespace Multipleof5
{
    internal class Program
    {
        public double check()
        {
            double output = 0;
            int count = 0;
            int sum = 0;
            Console.Write("Enter the limit:");
            int input1=Convert.ToInt32(Console.ReadLine());
            if(input1<0)
            {
                output = -1;
                return output;
            }
            if (input1 > 500)
            {
                output = -2;
                return output;
            }
            for(int i=1;i<=input1;i++)
            {
                if(i%5==0)
                {
                    count++;
                    sum += i;
                }
            }
            output = (double)sum / count;
            return output;
        }
        static void Main(string[] args)
        {
           Program obj=new Program();
            Console.WriteLine(obj.check());
        }
    }
}
