namespace FirstNonRepaetingCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            FindCharacter obj = new FindCharacter();
            obj.find(str);
        }
    }
}
