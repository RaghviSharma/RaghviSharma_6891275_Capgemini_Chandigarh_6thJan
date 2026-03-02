namespace CountDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = 0;
            Console.WriteLine("Enter the no to count digits:");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x < 0)
                output = -1;
            else
            {
                int temp = x;
                int count = 0;
                while(temp!=0)
                {
                    count++;
                    temp = temp / 10;
                }
                output= count;
            }
            Console.WriteLine(output);

        }
    }
}
