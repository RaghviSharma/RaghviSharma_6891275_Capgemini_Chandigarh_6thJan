namespace Calculator_App
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Calculator c = new Calculator();
                Console.WriteLine(c.add(1, 2));
                Console.WriteLine(c.subtract(5, 2));
                Console.WriteLine(c.multiply(1, 3));
                Console.WriteLine(c.divide(4, 2));

            }
        }
}

