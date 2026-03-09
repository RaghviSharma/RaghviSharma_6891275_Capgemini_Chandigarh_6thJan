namespace CubeOfPrime
{
    internal class Program
    {
		public Boolean isPrime(int n)
		{
			if (n == 1)
				return false;
			for (int i = 2; i < n; i++)
			{
				if (n % i == 0)
					return false;
			}
			return true;
		}
		public int find()
		{
			int output = 0;
			Console.WriteLine("Enter the limit:");
			int input = Convert.ToInt32(Console.ReadLine());
			if (input < 0)
			{
				output = -1;
			}
			else if (input > 32767)
				output = -2;
				for (int i = 1; i <= input; i++)
				{
					if (isPrime(i))
					{
						output += (int)Math.Pow(i, 3);
					}
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
