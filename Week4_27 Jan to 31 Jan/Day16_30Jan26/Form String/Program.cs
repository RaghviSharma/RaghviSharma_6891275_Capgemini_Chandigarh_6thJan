namespace Form_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int k = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[k];
            for(int i=0;i<array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the index");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.formString(array, n));
        }
    }
}
