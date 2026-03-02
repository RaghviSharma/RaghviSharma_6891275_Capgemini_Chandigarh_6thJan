using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace HotelProject
{
	public class Hotel : ICustomer
	{
		protected string? name; // customer name
		protected int roomType; // category
		public int noOfDays;
		protected int room; // room Id
		public int noOfVeh;

		protected static Dictionary<int, string> occupied = new Dictionary<int, string>();

		public void Cusdetails()
		{
			Console.Write("Enter the name of the customer: ");
			name = Console.ReadLine();

			Console.WriteLine("\n"+"Choose room type:");
			Console.WriteLine("1.Family  2.Full Duplex  3.Half Duplex");
			roomType = Convert.ToInt32(Console.ReadLine());

			Console.Write("\n"+"Enter room number: ");
			room = Convert.ToInt32(Console.ReadLine());

			Console.Write("\n"+"Enter number of vehicles you want to park: ");
			this.noOfVeh = Convert.ToInt32(Console.ReadLine());

			Console.Write("\n" + "Enter the number of days u want to stay for: ");
			this.noOfDays = Convert.ToInt32(Console.ReadLine());
		}


		public bool roomAllocate()
		{
			if (roomType == 1 && room > 0 && room <= 10 && !occupied.ContainsKey(room))
			{
				occupied.Add(room, "Family room");
				Console.WriteLine("Room allocated successfully");
				return true;
			}


			else if (roomType == 2 && room > 10 && room <= 20 && !occupied.ContainsKey(room))
			{
				occupied[room] = "Fully Duplex";
				Console.WriteLine("Room allocated successfully");
				return true;
			}

			else if (roomType == 3 && room > 20 && room <= 30 && !occupied.ContainsKey(room))
			{
				occupied[room] = "Half Duplex";
				Console.WriteLine("Room allocated successfully");
				return true;
			}

			else
			{
				Console.WriteLine("Room not available");
				return false;
			}
		}

		protected int freqOfFoodService;
		public void FoodAddOns(bool check)
		{

			if (check == true)
			{
				Console.Write("\n"+"...Do u want to add the meal service of our hotel..yes Or no: ");
				string? choice = Console.ReadLine();
				bool wantMeal = choice.Equals("yes");

				if (wantMeal == true)
				{
					Console.WriteLine();
					Console.WriteLine("Kindly tell us the number of time you want to avail the facility?? " +
						"(1 / 2 / 3)?");
					freqOfFoodService = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Great food facility is availed for your stay!!");
				}
				else
				{
					Console.WriteLine("\n"+"****No problem let's proceed further****");
				}
			}
		}
	}
}

