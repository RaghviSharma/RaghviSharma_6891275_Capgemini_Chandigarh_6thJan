namespace TicketManagement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<string> ticket = new Queue<string>();
			Console.WriteLine("Enter the number of users u want to enter: ");
			int num = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < num; i++)
			{
				Console.WriteLine("Enter the ticket num:");
				string str = Console.ReadLine();
				ticket.Enqueue(str);
			}
			Console.WriteLine("Incoming tickets in arrival: \n");
			foreach (var ch in ticket)
			{
				Console.WriteLine(ch);
			}
			Console.WriteLine("\nProcessing the current ticket: \n");
			string currentTicket = ticket.Dequeue();
			Console.WriteLine($"Current ticket is: {currentTicket}");

			Stack<string> actions = new Stack<string>();
			actions.Push("Updated status ");
			actions.Push("Assigned priority");
			actions.Push("Added customer");

			Console.WriteLine("\nActions performed: ");
			foreach (var act in actions)
			{
				Console.WriteLine(act);
			}
			Console.WriteLine("\nUndo the last action");
			string undo = actions.Pop();
			Console.WriteLine("\nThe remaining actions are:");
			foreach (var a in actions)
			{
				Console.WriteLine(a);
			}

		}
	}
}
