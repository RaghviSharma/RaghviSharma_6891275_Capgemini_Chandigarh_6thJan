using System;

namespace HotelProject
{
	internal class ShowDetails : Hotel
	{
		public void findDetails(bool check)
		{
			try
			{
				if (check)
				{
					Console.WriteLine("\n.....Room Allocation Status......");

					Console.WriteLine("Booking Confirmed");
					Console.WriteLine("Customer Name: " + name);
					Console.WriteLine("Room No: " + room);
					Console.WriteLine("Room Type is: " + roomType);
				}
				else
				{
					Console.WriteLine("Booking not confirmed");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error displaying details: " + ex.Message);
			}
		}

		public void DisplayCheckInRoom()
		{
			try
			{
				Console.WriteLine();
				Console.WriteLine("****The details of all the customers staying in hotel****");
				Console.WriteLine("Room no.  |  Category");
				foreach (var rooms in occupied)
				{
					Console.WriteLine(rooms.Key + "          " + rooms.Value);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error displaying check-in rooms: " + ex.Message);
			}
		}

		public void DisplayCheckOutRoom()
		{
			try
			{
				Console.WriteLine();
				Console.WriteLine("\nKindly verify the room details for check out:");
				Console.Write("Enter your room no please where you were staying: ");

				int roomNo = Convert.ToInt32(Console.ReadLine());

				if (occupied.ContainsKey(roomNo))
				{
					Console.WriteLine("You live in " + occupied[roomNo] + " right?");
					Console.Write("Are you sure you want to check out yes or no: ");
					string? status = Console.ReadLine();

					if (status != null && status.Equals("yes", StringComparison.OrdinalIgnoreCase))
					{
						occupied.Remove(roomNo);
						Console.WriteLine("...Check Out done Successfully...");
						Console.Write("Thanks for visiting! \n");
					}
					else
					{
						Console.Write("Enjoy your stay!");
					}
				}
				else
				{
					Console.WriteLine("No details available for the required room no.");
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Invalid input! Please enter a numeric value for the room number.");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error during check-out: " + ex.Message);
			}
		}
	}
}
