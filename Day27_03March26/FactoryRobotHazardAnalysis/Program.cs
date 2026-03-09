namespace FactoryRobotHazardAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter arm:");
            double arm=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter work density");
            int work=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter machinerystate");
            string machinery=Console.ReadLine();
            UserDefinedClass obj=new UserDefinedClass();
            Console.WriteLine(obj.CalculateHazardRisk(arm, work, machinery));
        }
    }
}
