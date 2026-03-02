namespace LeapYear
{
    internal class Program
    {
        public int check()
        {
            int output = 0;
            Console.Write("Enter the year u want to check:");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input<0)
            {
                output = -1;
                return output;
            }
            if(input%4==0&&input%100!=0)
            {
                output = 1;
                return output;
            }
            return output;
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            Console.WriteLine(obj.check());
        }
    }
}
