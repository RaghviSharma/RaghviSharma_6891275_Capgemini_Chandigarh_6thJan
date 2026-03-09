namespace MultipleOf3
{
    internal class Program
    {
        public int check()
        {
            int output = 0;
            Console.WriteLine("Enter the size of array:");
            int Input2=Convert.ToInt32 (Console.ReadLine());
            if(Input2<0)
            {
                output = -2;
                return output;
            }
            int[] Input1 = new int[Input2];
            Console.WriteLine("Enter the elements of array:");
            for(int i=0;i<Input2;i++)
            {
                Input1[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<Input2;i++)
            {
                if (Input1[i]<0)
                {
                    output = -1;
                    return output;
                }
            }
            int count = 0;
            for(int i=0;i<Input2;i++)
            {
                if (Input1[i] % 3 == 0)
                {
                    count++;
                    output = count;
                }

            }
            return output;

        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            Console.Write(obj.check());
        }
    }
}
