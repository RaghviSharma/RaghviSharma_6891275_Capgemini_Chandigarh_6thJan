namespace AlphabetAndVowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word");
            string input1 = Console.ReadLine();
			Console.WriteLine("Enter the second word");
			string input2 = Console.ReadLine();
            RemoveConsonant obj= new RemoveConsonant();
           Console.WriteLine( obj.find(input1, input2));
        }
    }
}
