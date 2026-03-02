namespace List_The_Elements_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of list:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> input1 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                input1.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Enter the number");
            int input2= Convert.ToInt32(Console.ReadLine());
         List<int> temp=UserProgramCode.GetElement(input1, input2);
            if(n==0)
            {
                Console.WriteLine("No element found");
                return;
            }    
            temp.Sort();
            temp.Reverse();
            foreach(var i in temp)
            {
                Console.Write(i + " ");
            }
            
        }
    }
}
