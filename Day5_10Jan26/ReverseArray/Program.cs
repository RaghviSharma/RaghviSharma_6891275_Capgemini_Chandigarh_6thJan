namespace ReverseArray
{
    internal class Program
    {
        public int[] find()
        {
            int[] output1;
            Console.WriteLine("Enter the size of array:");
                int Input2=Convert.ToInt32(Console.ReadLine());
            if(Input2<0)
            {
                output1 = new int[1];
                output1[0] = -2;
                return output1;
            }
            if(Input2%2==0)
            {
                output1=new int[1];
                output1[0] = -2;
                return output1;
            }
            int[] input1 = new int[Input2];
            Console.WriteLine("Enter the elements:");
            for(int i=0;i<Input2;i++)
            {
                input1[i]=Convert.ToInt32(Console.ReadLine());
            }
            foreach(int i in input1)
            {
                if(i<0)
                {
                    output1 = new int[1];
                    output1[0] = -1;
                    return output1;
                }
            }
            output1 = new int[Input2];
            for(int i=0;i<Input2;i++)
            {
                output1[i] = input1[Input2 - 1 - i];
            }
            return output1;
            


        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            int[] output = obj.find();
            foreach(int i in output)
            {
                Console.Write(i + " ");
            }
        }
    }
}
