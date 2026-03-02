using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace VehicleRentalSystem
{
    internal class Car:Vehicle
    {
		 static Dictionary<string, (int, int, string)> cars_d = new Dictionary<string, (int, int, string)>();
		public void Add()
        {
            Console.Write("Enter the name of the car:");
            v_name = Console.ReadLine();
            Console.Write("Enter the no of cars: ");
            v_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the charge of this vehicle: ");
            v_charge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the type of vehicle:");
            v_type = Console.ReadLine();
            cars_d.Add(v_name, (v_no, v_charge, v_type));
         
        }
        public void DisplayCars()
        {
            Console.WriteLine("The details of all cars are:");
            Console.WriteLine("\n--------------------------------------------------------------------------------");
            Console.WriteLine(" Name of car     | No of cars of this model  |  Charge of car |   Type of wheeler  ");
			Console.WriteLine("\n--------------------------------------------------------------------------------");
            foreach(var (key,value) in cars_d)
            {
                Console.WriteLine($"{key}         { value.Item1}            {value.Item2}    {value.Item3}");
            }
		}
    }
}
