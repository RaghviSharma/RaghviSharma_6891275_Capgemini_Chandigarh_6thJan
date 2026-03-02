using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	internal class Grade
	{
		public void Checkgrade()
		{
			Console.WriteLine("Enter marks of English:");
			int eng = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter marks of Math:");
			int math = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter marks of Science:");
			int sci = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter marks of Social Science:");
			int ssc = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter marks of Hindi:");
			int hindi = int.Parse(Console.ReadLine());
			double percent = (eng + math + sci + ssc + hindi) / 5;
			
			
				if(percent >90)
					Console.WriteLine("Grade is A+ Wuhhuu");
			else if(percent>80&&percent<=90)
				Console.WriteLine("Grade is A");
			else if (percent > 70 && percent <= 80)
					Console.WriteLine("Grade is B");
			else if (percent > 60 && percent <= 70)
				Console.WriteLine("Grade is C");
			else
				Console.WriteLine("Fail..oops");
			}
			static void Main(string[] args)
			{
				Grade obj = new Grade();
				obj.Checkgrade();



			}
		}
	}
