using System;

namespace HotelProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("********WELCOME TO HOTEL TAJ*********\n");

			// --- Customer Billing / Hotel ---
			Billing obj = new Billing();
			obj.Cusdetails();
			Console.WriteLine();

			bool status = obj.roomAllocate();

			if (status)
			{
				obj.findDetails(status);
				obj.DisplayCheckInRoom();
				obj.Parking_Det(status);
				obj.FoodAddOns(status);
				obj.Bill();
				obj.DisplayCheckOutRoom();
			}
			else
			{
				obj.findDetails(status);
			}

			// --- Servant Management ---
			ServantManager manager = new ServantManager();

			// Simple menu for managing servants
			while (true)
			{
				Console.WriteLine("\n--- Hotel Servant Management ---");
				Console.WriteLine("1. Add Servant");
				Console.WriteLine("2. Display All Servants");
				Console.WriteLine("3. Count Servants");
				Console.WriteLine("4. Clear All Servants");
				Console.WriteLine("5. Exit");
				Console.Write("Choose an option: ");

				string input = Console.ReadLine();
				switch (input)
				{
					case "1":
						manager.AddServant();
						break;
					case "2":
						manager.DisplayServants();
						break;
					case "3":
						manager.CountServants();
						break;
					case "4":
						manager.ClearServants();
						break;
					case "5":
						Console.WriteLine("Exiting servant management.");
						return;
					default:
						Console.WriteLine("Invalid choice! Try again.");
						break;
				}
			}
		}
	}
}
