namespace EligibleForVote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age of the person: ");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.isEligible(age));
        }
    }
}
