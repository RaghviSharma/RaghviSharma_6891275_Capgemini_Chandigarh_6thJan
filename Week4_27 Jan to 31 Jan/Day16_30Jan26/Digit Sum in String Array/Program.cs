namespace Digit_Sum_in_String_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in array: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            string[] input2 = new string[input1];
            for(int i=0;i<input1;i++)
            {
                input2[i] = Console.ReadLine();
            }
            Console.WriteLine(UserProgramCode.find(input2, input1));

        }
    }
}
