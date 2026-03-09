using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
    internal class Course : AssignCourse
    {
        static int cour_id = 1;
        static Dictionary<int, (string, string,string)> Courses = new Dictionary<int, (string, string,string)>();
        public void assignCourse()
        {
            Courses.Add(cour_id++, (p_name,C_name, C_id));
        }
        public void displayCourses()
        {
            Console.WriteLine("The details of courses assigned to professors are:");
            Console.WriteLine("\n----------------------------------------------------------------------");
            Console.WriteLine("    Professor id    |     Professor name  |   Course name   |  Course id  ");
			Console.WriteLine("\n----------------------------------------------------------------------");
			foreach (var (key, value) in Courses)
            {
                Console.WriteLine($"      {key}                   {value.Item1}              {value.Item2}             {value.Item3}");
            }
        }
    }
}
