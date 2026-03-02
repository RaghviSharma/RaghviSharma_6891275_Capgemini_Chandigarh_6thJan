namespace DivisibleBy3or5
{
    internal class Program
    {
        public int check()
        {
            int output = 0;
            Console.Write("Enter the number u want to check:");
            int Input1 = Convert.ToInt32(Console.ReadLine());
            if (Input1 < 0)
            {
                output = -1;
                return output;
            }
            if (Input1 % 3 == 0 || Input1 % 5 == 0)
            {
                output = -2; return output;
            }
            int product = 1;
            int temp = Input1;
            while (temp != 0)
            {
                int rem = temp % 10;
                product = product * rem;
                temp = temp / 10;
            }
            if (product % 3 == 0 || product % 5 == 0)
            {
                output = 1;
                return output;
            }

            return output;
        }
            static void Main(string[] args)
            {
                Program obj = new Program();
                Console.WriteLine(obj.check());
            }
        }
    }

