namespace PrimeNum
{
    internal class Program
    {
        public Boolean isPrime(int n)
        {
            if (n == 1)
                return false;
            if(n==2) return true;
            for(int i=2;i<n;i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public int check()
        {
            int output = 0;
            Console.WriteLine("Enter the size of array:");
            int Input2 = Convert.ToInt32(Console.ReadLine());
            if (Input2 < 0)
            {
                output = -2;
                return output;
            }
            Console.WriteLine("Enter the elements:");
            int[] Input1 = new int[Input2];
            for (int i = 0; i < Input2; i++)
            {
                Input1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Input2; i++)
            {
                if (Input1[i] < 0)
                {
                    output = -1;
                    return output;
                }
            }
            //check prime
            for (int i = 0; i < Input2; i++)
            {
                if (isPrime(Input1[i]) == true)
                {
                    output += Input1[i];
                }   
            }
            if (output == 0)
                return -3;
            return output;
            
        }

        static void Main(string[] args)
        {
            Program obj= new Program();
            Console.WriteLine(obj.check());
        }
    }
}
