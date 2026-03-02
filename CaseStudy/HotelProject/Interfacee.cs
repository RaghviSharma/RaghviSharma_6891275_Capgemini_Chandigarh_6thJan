using System;
using System.Collections.Generic;
using System.Text;
namespace HotelProject
{
	interface ICustomer
	{
		void Cusdetails();
	}
	interface IBilling
	{
		void Bill();
	}
	interface IParking
	{
		void Parking_Det(bool status);
	}
	
}