using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HospitalManagementSystem
{
	internal class Doctor : Person
	{
		public static int did = 1;
		static Dictionary<int, (string, string)> doctors = new Dictionary<int, (string, string)>();

		public void AddDoctor()
		{
			doctors.Add(did++, (Name, Email));
		}

		public void DisplayDoctors()
		{
			Console.WriteLine("\n--- Doctor List ---");
			foreach (var d in doctors)
				Console.WriteLine($"{d.Key}  {d.Value.Item1}  {d.Value.Item2}");
		}
	}
}
