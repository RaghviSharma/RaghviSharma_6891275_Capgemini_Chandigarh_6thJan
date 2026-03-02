using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
namespace ConsoleApp1
{
	public class Hotel
	{
		string HotelName;
		int roomNo;
		int vehNo;
		string Location;
		string cusName;

		public void Booking(string cusName, int roomNo)
		{
			this.cusName = cusName;
			this.roomNo = roomNo;
			Console.WriteLine("Customers name is:" + cusName);
			Console.WriteLine("Room no. is:" + roomNo);
		}
		public void RoomType()
		{
			if (roomNo < 5)
				Console.WriteLine("Room type is family room");
			else
				Console.WriteLine("Room type is couple room");
		}
		public void SetVehicle(int vehicles)
		{
			vehNo = vehicles;
		}
		public void Parking()
		{
			if (vehNo < 10)
			{
			vehNo++;
				Console.WriteLine("Yes parking is available");
				Console.WriteLine("New vehicle num is:" + vehNo);
			}
			else
				Console.WriteLine("Oops no parking available");

		}


	}
	class Check
	{
		static void Main(string[] args)
		{
			Hotel taj = new Hotel();
			Hotel arena = new Hotel();
			Console.Write("Enter name of customer:");
			string name = Console.ReadLine();
			Console.Write("Enter roomNo of customer:");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Enter existing vehicles for Hotel Taj:");
			int noOfVeh = int.Parse(Console.ReadLine());
			Console.WriteLine("--*Taj Hotel*--");
			taj.Booking(name, a);
			taj.RoomType();
			taj.SetVehicle(noOfVeh);
			taj.Parking();
			Console.WriteLine("--*Arena Hotel*--");
			Console.Write("Enter existing vehicles for Hotel Arena:");
			int noOfV = int.Parse(Console.ReadLine());
			arena.SetVehicle(noOfV);
			arena.Parking();
		}
	}
}