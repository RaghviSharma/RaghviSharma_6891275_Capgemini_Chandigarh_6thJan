namespace CelsiusCon
{
    internal class Program
    {
        public double find()
        {
            double output = 0;
            Console.WriteLine("Enter the value in F:");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x<0)
            {
                output = -1;
                return output;
            }
            output = (x - 32) * (5.0 / 9);
            return output;


        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            Console.Write(obj.find());
        }
    }
}
