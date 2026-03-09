namespace Armstrong
{
    internal class Program
    {
		public int check()
		{
			Console.Write("Enter the number to check:");
			int x = int.Parse(Console.ReadLine());
			int output1 = 0;
			int length = 0;
			int temp;
			temp = x;
			while (temp != 0)
			{
				length = length + 1;
				temp = temp / 10;
			}

			if (x < 0)
				output1 = -1;
			else if (length > 3)
				output1 = -3;
			else
				output1 = help(x, length, output1);
			return output1;

		}
		public int help(int x, int length, int output1)
		{
			int result = 0;
			int rem = 0;
			int temp = x;
			while (temp != 0)
			{
				rem = temp % 10;
				result += (int)Math.Pow(rem, length);
				temp = temp / 10;
			}
			if (result == x)
				output1 = 1;
			else output1 = 0;
			return output1;
		}
		static void Main(string[] args)
		{
			Program obj = new Program();
			Console.WriteLine(obj.check());


		}
	}
}
