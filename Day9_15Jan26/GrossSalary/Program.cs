namespace GrossSalary
{
    internal class Program
    {
        public double calculate()
        {
            double gross = 0;
            Console.Write("Enter the basic salary:");
            int basic_pay=Convert.ToInt32(Console.ReadLine());
            if (basic_pay < 0)
            {
                gross = -1;
                return gross;
            }
            else if(basic_pay>10000)
            {
                gross = -2;
                return gross;
            }
            gross=basic_pay+(0.75 * basic_pay)+(0.5 * basic_pay );
            return gross;
        }
        static void Main(string[] args)
        {
            Program obj= new Program();
            Console.Write(obj.calculate());
        }
    }
}
