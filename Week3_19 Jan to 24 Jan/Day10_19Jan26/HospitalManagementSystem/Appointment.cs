using System;
using System.Collections.Generic;

namespace HospitalManagementSystem
{
	internal class Appointment
	{
		static List<string> appointments = new List<string>();

		public void Schedule(int pid, int did, string date)
		{
			appointments.Add($"Patient:{pid} Doctor:{did} Date:{date}");
		}

		public void View()
		{
			Console.WriteLine("\n--- Appointments ---");
			foreach (var a in appointments)
				Console.WriteLine(a);
		}
	}
}
