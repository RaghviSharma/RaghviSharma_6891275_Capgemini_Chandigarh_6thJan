using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
	internal class Teacher : Person
	{
		static int teach_id = 1;
		protected static Dictionary<int, (string, string)> teachers = new Dictionary<int, (string, string)>();
		public void teacher_Details()
		{
			teachers.Add(teach_id++, (Person_name, Person_email));
		}
		public void display_DetailsTeacher()
		{
			Console.WriteLine("Details of the registered teachers are:\n");
			Console.WriteLine("--------------------------------------");
			Console.WriteLine("   Id     |    Name  |   Email Id  ");
			Console.WriteLine("--------------------------------------");

			foreach (var (key, value) in teachers)
			{

				Console.WriteLine($"   {key}           {value.Item1}       {value.Item2}");
			}

		}
	}
}
