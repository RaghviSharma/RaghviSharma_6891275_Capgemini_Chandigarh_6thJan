namespace ReachTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Console.Write("Enter the target element:");
            int target = Convert.ToInt32(Console.ReadLine());
            ReachElement obj= new ReachElement();
            Console.WriteLine(obj.findNo(num,target));
        }
    }
}
