namespace Maximum_Strength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of employees skill:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] skill = new int[size];
            Console.WriteLine("Enter the elements:");
            for(int i=0; i<skill.Length; i++)
            {
                skill[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the team size:");
            int size2=Convert.ToInt32(Console.ReadLine());
            int[] teamSize=new int[size2];
			Console.WriteLine("Enter the elements:");
			for (int i = 0; i <size2; i++)
			{
				teamSize[i] = Convert.ToInt32(Console.ReadLine());
			}


		}
    }
}
