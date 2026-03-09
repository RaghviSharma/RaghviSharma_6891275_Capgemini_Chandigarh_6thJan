namespace Hashtag_Extraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to extract hashtags: ");
            string hashtag = Console.ReadLine();
            Console.WriteLine(UserProgramCode.FindHashTags(hashtag));
        }
    }
}
