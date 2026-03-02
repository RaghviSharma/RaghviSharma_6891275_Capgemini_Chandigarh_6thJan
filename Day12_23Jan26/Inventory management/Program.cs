using System.Security.Cryptography.X509Certificates;

namespace Inventory_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManage obj=new BookManage();

           while(true)
            {
                Console.WriteLine("Enter the choice: ");
                Console.WriteLine("1. Add new books to inventory");
                Console.WriteLine("2. Display the book detail ");
                Console.WriteLine("3. Find all books cheaper than a target price");
                Console.WriteLine("4. Increase the price of all books by a percentage during a sale");
                Console.WriteLine("5. Remove out of stock books: ");
                Console.WriteLine("6. Exit..");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                      case 1:
                        obj.store();
                        break;
                      case 2:
                        obj.Display();
                        break;
                      case 3:
                        obj.cheaper();
                        break;
                    case 4:
                        obj.sale();
                        break;
                    case 5:
                        obj.outOfStock();
                        break;
                    case 6:
                        Console.WriteLine("Exiting from page..Thank You");
                        return;
                }
			}
        }
    }
}
