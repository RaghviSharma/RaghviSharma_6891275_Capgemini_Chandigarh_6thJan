namespace BankManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome to State Bank Of India*********\n");
  
            Console.WriteLine("Enter your choice:\n");
            Console.WriteLine("1. Saving Account");
            Console.WriteLine("2. Checking Account");
            Console.WriteLine("3. Exit ");
			int choice = Convert.ToInt32(Console.ReadLine());
            bool exiting = true;
            while(exiting)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the action u want to perform: ");
                        Console.WriteLine("1. Deposit Money\n2.Withdraw Money\n3.DisplayAccountSummary\n4.Check Interest\n5.Exit");
						SavingAccount cust1 = new SavingAccount();
						cust1.Account_no = 17255;
						cust1.Account_name = "Raghvi Sharma";
						int action = Convert.ToInt32(Console.ReadLine());
                        switch (action)
                        {

					       case 1:
                                cust1.depositMoney();
                                break;
                            case 2:
                                cust1.withDrawMoney();
                                break;
                            case 3:
                                cust1.DisplayAccountSummary();
                                break;
                            case 4:
                                cust1.checkInterest();
                                break;
                            case 5:
                                return;
                        }
                        break;
                    case 2:
                        CheckingAccount obj = new CheckingAccount();
                        obj.Account_no = 16779;
                        obj.Account_name = "Riya";
						Console.WriteLine("Enter the action u want to perform: ");
						Console.WriteLine("1. Deposit Money  \n2. Withdraw Money \n3. DisplayAccountSummary \n4.Check Interest   \n5.Exit");
						int act = Convert.ToInt32(Console.ReadLine());
						switch (act)
						{

							case 1:
								obj.depositMoney();
								break;
							case 2:
								obj.withDrawMoney();
								break;
							case 3:
								obj.DisplayAccountSummary();
								break;
							case 4:
								obj.checkInterest();
								break;
							case 5:
								return;
						}
						break;

                    case 3:
                        exiting = false;
                        break;
                }
            }
        }
    }
}

