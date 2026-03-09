namespace CountVowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string s=Console.ReadLine();
            VowelsInStr obj=new VowelsInStr();
            Console.Write(obj.count(s));
        }
    }
}
