using System;
using System.Collections.Generic;

namespace HospitalManagementSystem
{
	internal class MedicalRecord
	{
		static Dictionary<int, string> records = new Dictionary<int, string>();

		public void AddRecord(int patientId, string history)
		{
			records[patientId] = history;
		}

		public void ViewRecord(int patientId)
		{
			if (records.ContainsKey(patientId))
				Console.WriteLine("Medical History: " + records[patientId]);
			else
				Console.WriteLine("No record found.");
		}
	}
}
