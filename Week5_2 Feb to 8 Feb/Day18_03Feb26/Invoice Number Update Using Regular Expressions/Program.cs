namespace Invoice_Number_Update_Using_Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the value u want to increment:");
            int input2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.UpdateCode(input1, input2));
        }
    }
}
