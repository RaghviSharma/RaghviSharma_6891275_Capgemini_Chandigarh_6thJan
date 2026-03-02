using System;

namespace HotelProject
{
	internal class Billing : Parking
	{
		int bill = 0;

		public void Bill()
		{
			bill = noOfDays * noOfVeh * 50;
			bill += freqOfFoodService * 500;

			if (roomType == 1)
			{
				bill += noOfDays * 2000;
			}

			else if (roomType == 2)
			{
				bill += noOfDays * 3500;
			}

			else
			{
				bill += noOfDays * 2500;
			}
			Console.WriteLine("\n" + "****Please clear the bill mentioned below before check out:");
			Console.WriteLine("\n" + "Total Bill including all the expenses: " + bill);
		}
	}
}
