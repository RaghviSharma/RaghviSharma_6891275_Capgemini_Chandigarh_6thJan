using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
    internal class Student:Person
    {
		public static int stud_Id=1;
		static Dictionary<int, (string,string)> students = new Dictionary<int,(string,string)>();

		public void student_Details()
        {
			students.Add(stud_Id++, (Person_name, Person_email));

		}
        public void display_DetailsStudents()
        {
			Console.WriteLine("Details of the registered students are:\n");
			Console.WriteLine("--------------------------------------");
			Console.WriteLine("   Id     |    Name  |   Email Id  ");
			Console.WriteLine("--------------------------------------");
			foreach (var (key, value) in students)
			{

				Console.WriteLine($"   {key}           {value.Item1}       {value.Item2}");
			}

		}

	}
}
