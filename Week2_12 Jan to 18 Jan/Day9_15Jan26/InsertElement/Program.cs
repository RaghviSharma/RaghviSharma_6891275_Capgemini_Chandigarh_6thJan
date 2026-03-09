namespace InsertElement
{
    internal class Program
    {
        public int[] insert()
        {
			Console.Write("Enter the size of array:");
			int input2 = Convert.ToInt32(Console.ReadLine());
			int[] output;
			if (input2 < 0)
			{
				output = new int[1];
				output[0] = -2;
				return output;
			}
			Console.WriteLine("Enter the elements of array:");
			int[] input1 = new int[input2];
			for (int i = 0; i < input2; i++)
			{
				input1[i] = Convert.ToInt32(Console.ReadLine());
				if (input1[i] < 0)
				{
					output = new int[1];
					output[0] = -2;
				}
			}
			input1.Sort();
			Array.Resize(ref input1, input1.Length+1);
			Console.Write("Enter the location to insert element:");
			int location = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the element:");
			int element = Convert.ToInt32(Console.ReadLine());
			for(int i=input1.Length-2;i>=location;i--)
			{
				input1[i+1] = input1[i];
			}
			input1[location] = element;
			return input1;

		}
        static void Main(string[] args)
        {
           Program obj=new Program();
			int[] output1 = obj.insert();
			foreach(int i in output1)
			{
				Console.Write(i + " ");
			}
        }
    }
}
