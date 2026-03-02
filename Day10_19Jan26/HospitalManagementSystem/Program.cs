using System;
using System.Numerics;

namespace HospitalManagementSystem
{
	internal class Program
	{
		static void Main()
		{
			Patient p = new Patient();
			Doctor d = new Doctor();
			Nurse n = new Nurse();
			Appointment a = new Appointment();
			MedicalRecord m = new MedicalRecord();

			while (true)
			{
				Console.WriteLine("\n1.Register Patient");
				Console.WriteLine("2.Register Doctor");
				Console.WriteLine("3.Register Nurse");
				Console.WriteLine("4.Schedule Appointment");
				Console.WriteLine("5.Add Medical Record");
				Console.WriteLine("6.View Data");
				Console.WriteLine("7.Exit");

				int ch = Convert.ToInt32(Console.ReadLine());

				switch (ch)
				{
					case 1:
						Console.Write("Enter Patient Name: ");
						p.Name = Console.ReadLine();
						Console.Write("Enter Email: ");
						p.Email = Console.ReadLine();
						p.AddPatient();
						break;

					case 2:
						Console.Write("Enter Doctor Name: ");
						d.Name = Console.ReadLine();
						Console.Write("Enter Email: ");
						d.Email = Console.ReadLine();
						d.AddDoctor();
						break;

					case 3:
						Console.Write("Enter Nurse Name: ");
						n.Name = Console.ReadLine();
						Console.Write("Enter Email: ");
						n.Email = Console.ReadLine();
						n.AddNurse();
						break;

					case 4:
						Console.Write("Enter Patient Id: ");
						int pid = Convert.ToInt32(Console.ReadLine());
						Console.Write("Enter Doctor Id: ");
						int did = Convert.ToInt32(Console.ReadLine());
						Console.Write("Enter Date: ");
						string date = Console.ReadLine();
						a.Schedule(pid, did, date);
						break;

					case 5:
						Console.Write("Enter Patient Id: ");
						int rid = Convert.ToInt32(Console.ReadLine());
						Console.Write("Enter History: ");
						string h = Console.ReadLine();
						m.AddRecord(rid, h);
						break;

					case 6:
						p.DisplayPatients();
						d.DisplayDoctors();
						n.DisplayNurses();
						a.View();
						break;

					case 7:
						return;
				}
			}
		}
	}
}
