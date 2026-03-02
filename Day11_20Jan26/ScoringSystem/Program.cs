namespace ScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of marks awarded for type 1 questions: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of marks awarded for type 2 questions: ");
            int Y= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of questions of type 1: ");
            int n1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of questions of type 2: ");
            int n2= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total marks obtained :");
            int M= Convert.ToInt32(Console.ReadLine());
            ValidCalculation obj= new ValidCalculation();
            obj.checkIsValid(X, Y, n1, n2, M);
        }
    }
}
