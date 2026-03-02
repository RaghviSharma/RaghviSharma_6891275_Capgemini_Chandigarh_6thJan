using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HotelProject
{
    internal class Parking:ShowDetails,IParking
    {
		protected static int vehicles=0;
		protected const int totalVeh = 50;
		public void Parking_Det(Boolean status)
        {
            if (status== true)
            {
				Console.WriteLine("\n"+"****The parking details along with parking id ****");
				if (vehicles < totalVeh)
                {
                    Console.WriteLine("Parking is available");
                    int parkingId = vehicles;
                    int j = 1;
                    for (int i = vehicles+1; i <= noOfVeh + vehicles; ++i)
                    {
                        Console.WriteLine("The parking id of "+ j+" vehicle is: " + i);
                        j++;
                    }
					vehicles += noOfVeh;
				}
                else
                {
                    Console.WriteLine("Parking is not available");
                }
            }

            else
            {
                Console.Write("No parking because no room is allocated!!");
            }

        }
    }
}
