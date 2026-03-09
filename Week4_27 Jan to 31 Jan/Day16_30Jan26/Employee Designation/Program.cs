namespace Employee_Designation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int n=Convert.ToInt32(Console.ReadLine());
            string[] input1=new string[n];
            for(int i=0;i<input1.Length; i++)
            {
                input1[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the value: ");
            string input2=Console.ReadLine();
            string[] answer = UserProgramCode.getEmployee(input1, input2);
            foreach (string s in answer)
            {
                Console.WriteLine(s);
            }
        }
    }
}
