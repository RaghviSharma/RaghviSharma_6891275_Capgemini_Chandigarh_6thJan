namespace EvenDigitSum
{
    internal class Program
    {
        public int check()
        {
            int output = 0;
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num<0)
            {
                output = -1;
                return output;
            } 
            if(num>32767)
            {
                output = -2; 
                return output;
            }
            int temp = num;
            while(temp!=0)
            {
                int rem = temp % 10;
                if (rem % 2 == 0)
                    output += rem;
                temp = temp / 10;
            }
            return output;
        }
        static void Main(string[] args)
        {
            Program obj= new Program();
            Console.WriteLine(obj.check());
        }
    }
}
