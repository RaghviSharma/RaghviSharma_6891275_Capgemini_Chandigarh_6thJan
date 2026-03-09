namespace LongestSubstringWithoutRepeating
{
    internal class Program
    {
        static void Main(string[] args)
        {
           FindSubstring obj=new FindSubstring();
            Console.WriteLine("ENter the string: ");
            string str = Console.ReadLine();
            obj.Find(str);
        }
    }
}
