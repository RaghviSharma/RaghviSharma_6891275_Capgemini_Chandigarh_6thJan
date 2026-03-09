namespace LuckyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting and ending number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(LuckyNum.countLN(input1,input2));


        }
    }
}
