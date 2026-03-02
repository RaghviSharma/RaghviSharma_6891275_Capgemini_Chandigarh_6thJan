namespace Location_Code_Update_in_Invoice_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the invoice number: ");
            string? input1 = Console.ReadLine();
            Console.Write("Enter the new location code: ");
            string? input2 = Console.ReadLine();
            Console.WriteLine(UserProgramCode.UpdatedLocation(input1, input2));
        }
    }
}
