using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace VehicleRentalSystem
{
    internal class Truck:Vehicle
    {

		static Dictionary<string, (int, int, string)> truck_d = new Dictionary<string, (int, int, string)>();
		public void Add()
		{
			Console.Write("Enter the name of the truck:");
			v_name = Console.ReadLine();
			Console.Write("Enter the no of trucks: ");
			v_no = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the charge of this vehicle: ");
			v_charge = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the type of vehicle:");
			v_type = Console.ReadLine();
			truck_d.Add(v_name, (v_no, v_charge, v_type));

		}
		public void DisplayTrucks()
		{
			Console.WriteLine("The details of all cars are:");
			Console.WriteLine("\n--------------------------------------------------------------------------------");
			Console.WriteLine(" Name of truck     | No of trucks of this model  |  Charge of truck |   Type of wheeler  ");
			Console.WriteLine("\n--------------------------------------------------------------------------------");
			foreach (var (key, value) in truck_d)
			{
				Console.WriteLine($"{key}     {value.Item1}     {value.Item2}    {value.Item3}");
			}
		}
	}

}
