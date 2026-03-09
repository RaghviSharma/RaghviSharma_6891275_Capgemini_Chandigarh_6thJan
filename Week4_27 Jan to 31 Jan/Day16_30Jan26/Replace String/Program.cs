namespace Replace_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string input1=Console.ReadLine();

            Console.WriteLine("Enter the index: ");
            int idx=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the special character:");
            char ch=Convert.ToChar(Console.ReadLine());
                string output= UserProgramCode.replace(input1,idx,ch);
            if (output == "-1")
                Console.WriteLine("Invalid String");
            else if (output == "-2")
                Console.WriteLine("Number not positive");
            else if (output == "-3")
                Console.WriteLine("Character not a special character");
            else
                Console.WriteLine(output);
        }
    }
}
