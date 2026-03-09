using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Grading
{
    internal class Student
    {
        static Dictionary<int,(string name,double grade)> details=new Dictionary<int, (string, double)> ();
        public void detail()
        {
            Console.WriteLine("Enter the number of students:");
            int n=Convert.ToInt32 (Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter the id of student:");
                int id= Convert.ToInt32 (Console.ReadLine());

                Console.WriteLine("Enter the name of the student: ");
                string name= Console.ReadLine();

                Console.WriteLine("Enter the grade of the students: ");
                double grade = Convert.ToDouble(Console.ReadLine());
                details.Add(id, (name, grade));
            }
        }
        public void display()
        {
            Console.WriteLine("Details of the students are: \n");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("   Id   |  Name  | Grade  ");
            foreach(var (key,value) in details)
            {
                Console.WriteLine($"    {key}        {value.name}    {value.grade}  ");
            }
        }
        public void avg()
        {
            double avg = 0;
            foreach(var (key,value) in details)
            {
                avg += value.grade;
            }
            avg=avg/details.Count;
            Console.WriteLine("Average of all students is :" + avg);
        }
        public void risk()
        {
            Console.WriteLine("Enter the threshold value: ");
            int a=Convert.ToInt32 (Console.ReadLine());
            foreach(var (key,value) in details)
            {
                Predicate<double> atRisk = g=>g< a;
                {
                    if (atRisk(value.grade))
                    {
                        Console.WriteLine("  Id   |  Name     |    Grade  ");
                        Console.WriteLine($" {key}       {value.name}       {value.grade}  ");
                    }
                }
            }
        }
        public void reevaluate()
        { 
			Console.WriteLine("Enter the id of student you want to update marks: ");
			int u_id = Convert.ToInt32(Console.ReadLine());

			if (details.ContainsKey(u_id))
			{
				Console.WriteLine("Enter new grade: ");
				double newGrade = Convert.ToDouble(Console.ReadLine());

				var oldData = details[u_id];              
				details[u_id] = (oldData.name, newGrade); 

				Console.WriteLine("Marks updated successfully!");
				Console.WriteLine("Enter threshold to re-check risk:");
				double threshold = Convert.ToDouble(Console.ReadLine());

				if (newGrade < threshold)
					Console.WriteLine("Student is at risk.");
				else
					Console.WriteLine("Student is safe.");
			}
			else
			{
				Console.WriteLine("Student ID not found!");
			}
		}

	}

}

