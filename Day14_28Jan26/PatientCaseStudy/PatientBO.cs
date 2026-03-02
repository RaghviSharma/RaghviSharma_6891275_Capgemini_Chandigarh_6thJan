using System;
using System.Collections.Generic;
using System.Text;

namespace PatientCaseStudy
{
	internal class PatientBO
	{
		public void DisplayPatientDetails(List<Patient> patientList, string name)
		{
			foreach (var p in patientList)
			{
				if (p.Name != name)
				{
					Console.WriteLine($"Patient named {name} not found", name);
				}
				else
				{
					Console.WriteLine("Name     Age   Illness   City");
					Console.WriteLine($"{p.Name}   {p.Age}   {p.illness}   {p.City}");
				}
			}
		}
		public void DisplayYoungestPatientDetails(List<Patient> patientList)
		{
			int minAge = int.MaxValue;
			foreach (var p in patientList)
			{
				if (p.Age < minAge)
				{
					minAge = p.Age;
				}
			}
			foreach (var p in patientList)
			{
				if (p.Age == minAge)
				{
					Console.WriteLine("Name     Age   Illness   City");
					Console.WriteLine($"{p.Name}    {p.Age}    {p.illness}    {p.City}");
					break;
				}
			}
		}
		public void displayPatientsFromCity(List<Patient> patientList, string cname)
		{
			foreach (var p in patientList)
			{
				if (p.City != cname)
				{
					Console.WriteLine($"City named {cname} not found", cname);
				}
				else
				{
					Console.WriteLine("Name     Age   Illness   City");
					Console.WriteLine($"{p.Name}    {p.Age}    {p.illness}    {p.City}");
				}
			}
		}
	}
}
