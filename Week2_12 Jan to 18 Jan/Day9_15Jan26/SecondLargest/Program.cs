namespace SecondLargest
{
    internal class Program
    {
        public int find()
        {
            int output1 = 0;
            Console.Write("Enter the size of array:");
            int input3=Convert.ToInt32(Console.ReadLine());
            if(input3<0)
            {
                output1 = -2;
                return output1;
            }
            Console.WriteLine("Enter the elements of array:");
            int[] input1 = new int[input3];
            for(int i=0;i<input3;i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
                if (input1[i]<0)
                {
                    output1 = -1;
                    return output1;
                }
            }
            input1.Sort();
            int k = 0;
            for (int i = 1; i < input3; i++)
            {
                if (input1[i] == input1[k])
                {
                    i++;
                }
                else
                {
                    k++;
                    input1[k] = input1[i];
                }
            }
            if(k>=1)
            {
                output1 = input1[k - 1];
            }
            else
            {
                output1 = -3;
            }
            return output1;

}
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.Write(obj.find());
        }
    }
}
