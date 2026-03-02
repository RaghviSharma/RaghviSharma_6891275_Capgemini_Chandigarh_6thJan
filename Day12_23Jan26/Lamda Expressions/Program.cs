namespace Lamda_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Even nums are:");
            List<int> ans = list.FindAll(X => X % 2 == 0);
            foreach (int x in ans)
            {
                Console.WriteLine("{0} ", x);

            }
            var cube = list.Select(x => x * x * x);
            Console.WriteLine("Cubes of nums are:");
            foreach(int n in cube)
            {
                Console.WriteLine("{0}", n);
            }
        }
    }
}
