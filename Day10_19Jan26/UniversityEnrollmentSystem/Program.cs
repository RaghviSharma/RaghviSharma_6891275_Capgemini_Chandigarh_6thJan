namespace UniversityEnrollmentSystem
{
    internal class Program
    {
		static void Main(string[] args)
        {
			while (true)
            {
                Console.WriteLine("Enter your choice:\n");
                Console.WriteLine("1. Register students");
                Console.WriteLine("2. Register teachers");
                Console.WriteLine("3. Assign courses");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
						Student s1 = new Student();
						Console.Write("Enter the number of students:");
						int n = Convert.ToInt32(Console.ReadLine());
						for (int i = 1; i <= n; i++)
						{
							Console.Write("Enter the name of the student " + i + ": ");
							s1.Person_name = Console.ReadLine();
							Console.Write("Enter the email id of the student " + i + ": ");
							s1.Person_email = Console.ReadLine();
							s1.student_Details();
						}
						Console.WriteLine();
						s1.display_DetailsStudents();
                        break;
                    case 2:
						Teacher t1 = new Teacher();
						Console.WriteLine("Enter the number of teacher:");
						int m = Convert.ToInt32(Console.ReadLine());
						
						for (int i = 1; i <= m; i++)
						{
							Console.Write("Enter the name of the teacher " + i + ": ");
							t1.Person_name = Console.ReadLine();
							Console.Write("Enter the email id of the teacher " + i + ": ");
							t1.Person_email = Console.ReadLine();
							t1.teacher_Details();
						}
						Console.WriteLine();
						t1.display_DetailsTeacher();
						break;
					case 3:
						Console.WriteLine("Enter the number of courses u want to assign:");
						int p = Convert.ToInt32(Console.ReadLine());
						Course c1 = new Course();
						for (int i = 1; i <= p; i++)
						{
							Console.WriteLine("Enter the name of the proffessor:");
							c1.p_name = Console.ReadLine();
							Console.WriteLine("Enter the name of the course: ");
							c1.Course_name = Console.ReadLine();
							Console.WriteLine("Enter the id of the assigned course: ");
							c1.Course_id = Console.ReadLine();
						}
						Console.WriteLine();
						c1.assignCourse();
						c1.displayCourses();
                        break;
                    case 4:
                        Console.WriteLine("Exiting from page..Thank You");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!!");
                        break;
                }
            }

		}
    }
}
