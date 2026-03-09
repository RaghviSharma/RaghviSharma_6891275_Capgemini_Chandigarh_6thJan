namespace VehicleRentalSystem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("\nEnter the task you want to perform:");
				Console.WriteLine("1. Enter the car details");
				Console.WriteLine("2. Enter the bike details");
				Console.WriteLine("3. Enter the truck details");
				Console.WriteLine("4. Show car details");
				Console.WriteLine("5. Show bike details");
				Console.WriteLine("6. Show truck details");
				Console.WriteLine("7. Exit");

				int choice = Convert.ToInt32(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Car car = new Car();
						car.Add();
						break;

					case 2:
						Bike bike = new Bike();
						bike.Add();
						break;

					case 3:
						Truck truck = new Truck();
						truck.Add();
						break;

					case 4:
						Car c = new Car();
						c.DisplayCars();
						break;

					case 5:
						Bike b = new Bike();
						b.DisplayBikes();
						break;

					case 6:
						Truck t = new Truck();
						t.DisplayTrucks();
						break;

					case 7:
						Console.WriteLine("Thank you!");
						return;

					default:
						Console.WriteLine("Invalid choice!");
						break;
				}
			}
		}
	}
}
