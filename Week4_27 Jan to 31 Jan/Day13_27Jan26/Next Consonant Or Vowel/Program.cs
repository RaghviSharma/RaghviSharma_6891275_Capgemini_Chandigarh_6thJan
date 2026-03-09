namespace Next_Consonant_Or_Vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str=Console.ReadLine();
            FindNextVowel obj=new FindNextVowel();
            Console.WriteLine(obj.nextString(str));
        }
    }
}
