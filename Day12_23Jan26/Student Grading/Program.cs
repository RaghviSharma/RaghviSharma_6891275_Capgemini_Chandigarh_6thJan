namespace Student_Grading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            while(true)
            {
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1. Add the student details");
                Console.WriteLine("2. Display the student details");
                Console.WriteLine("3. Calculate the average score ");
                Console.WriteLine("4. Evaluate the students at risk");
                Console.WriteLine("5. Update the marks and reevaluate risk");
                Console.WriteLine("6. Exit..");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        student.detail();
                        break;
                    case 2:
                        student.display();
                        break;
                    case 3:
                        student.avg();
                        break;
                    case 4:
                        student.risk();
                        break;
                    case 5:
                        student.reevaluate();
                        break;
                    case 6:
                        Console.WriteLine("Exiting from page ");
                        return;

                }
            }
        }
    }
}
