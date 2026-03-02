using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace VehicleRentalSystem
{
    internal class Bike:Vehicle
    {

		static Dictionary<string, (int, int, string)> bike_D = new Dictionary<string, (int, int, string)>();
		public void Add()
		{
			Console.Write("Enter the name of the bike:");
			v_name = Console.ReadLine();
			Console.Write("Enter the no of bikes: ");
			v_no = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the charge of this vehicle: ");
			v_charge = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the type of vehicle:");
			v_type = Console.ReadLine();
			bike_D.Add(v_name, (v_no, v_charge, v_type));

		}
		public void DisplayBikes()
		{
			Console.WriteLine("The details of all cars are:");
			Console.WriteLine("\n--------------------------------------------------------------------------------");
			Console.WriteLine(" Name of bike     | No of bikes of this model  |  Charge of bike |   Type of wheeler  ");
			Console.WriteLine("\n--------------------------------------------------------------------------------");
			foreach (var (key, value) in bike_D)
			{
				Console.WriteLine($"{key}     {value.Item1}     {value.Item2}    {value.Item3}");
			}
		}
	}
}
