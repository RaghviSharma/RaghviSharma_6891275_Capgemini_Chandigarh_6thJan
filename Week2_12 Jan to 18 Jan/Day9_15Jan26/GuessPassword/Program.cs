namespace GuessPassword
{
    internal class Program
    {
        public int guess()
        {
            int output = 0;
            Console.Write("Enter the size of array:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0)
            {
                output = -2;
                return output;
            }
            Console.WriteLine("Enter the elements of array:");
            int[] input1 = new int[input2];
            for (int i = 0; i < input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
                if (input1[i] < 0)
                {
                    output = -1;
                    return output;
                }
            }
            int oddSum = 0;
            int evenSum = 0;
            foreach(int i in input1)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                    oddSum += i;
            }
            output = (int)(oddSum + evenSum) / 2;
            return output;
        }
              static void Main(string[] args)
              {
                      Program obj=new Program();
                    Console.WriteLine(obj.guess());
              }
    }
}
