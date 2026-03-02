using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HospitalManagementSystem
{
	internal class Patient : Person
	{
		public static int pid = 1;
		static Dictionary<int, (string, string)> patients = new Dictionary<int, (string, string)>();

		public void AddPatient()
		{
			patients.Add(pid++, (Name, Email));
		}

		public void DisplayPatients()
		{
			Console.WriteLine("\n--- Patient List ---");
			foreach (var p in patients)
				Console.WriteLine($"{p.Key}  {p.Value.Item1}  {p.Value.Item2}");
		}
	}
}
