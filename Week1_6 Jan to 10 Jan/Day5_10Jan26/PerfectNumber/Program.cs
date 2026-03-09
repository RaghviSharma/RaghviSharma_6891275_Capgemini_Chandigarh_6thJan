namespace PerfectNumber
{
    internal class Program
    {
        public int find()
        {
            int output = -1;
            Console.WriteLine("Enter the number u want to check:");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input < 0)
            {
                output = -2;
                return output;
            }
            int sum = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                    sum=sum+i;
            }
            if (sum == input)
            {
                output = 1;
                return output;

            }
            return output;
        }
                
            
        static void Main(string[] args)
        {
            Program obj= new Program();
            Console.Write(obj.find());
        }
    }
}
