using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HospitalManagementSystem
{
	internal class Nurse : Person
	{
		public static int nid = 1;
		static Dictionary<int, (string, string)> nurses = new Dictionary<int, (string, string)>();

		public void AddNurse()
		{
			nurses.Add(nid++, (Name, Email));
		}

		public void DisplayNurses()
		{
			Console.WriteLine("\n--- Nurse List ---");
			foreach (var n in nurses)
				Console.WriteLine($"{n.Key}  {n.Value.Item1}  {n.Value.Item2}");
		}
	}
}
