using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    internal class CheckingAccount : BankAccount
    {
        int num;
		int amount;
		public void depositMoney()
		{
			Console.WriteLine("Enter the amount u want to deposit:");
			amount = Convert.ToInt32(Console.ReadLine());
			ExistingBalance += amount;
			Console.WriteLine("The amount has been deposited succesfully!!");
			Console.WriteLine("\n" + "The amount is updated to: " + ExistingBalance + "\n");
		}
		public void withDrawMoney()
		{
			Console.WriteLine("Enter the amount u want to withdraw:");
			amount = Convert.ToInt32(Console.ReadLine());
			if (amount > ExistingBalance)
			{
				Console.WriteLine("Required balance is not available");
			}
			else
			{
				ExistingBalance -= amount;
				Console.WriteLine("The amount has been withdrawl succesfully!!");
				Console.WriteLine("\n" + "The amount is updated to: " + ExistingBalance + "\n");
			}
		}

		public void DisplayAccountSummary()
		{

			Console.WriteLine("Account statement of user with Account no:" + Account_no + " is: ");
			Console.WriteLine("Total amount in your account is: " + ExistingBalance + "\n");
		}
		public void checkInterest()
		{

			double interest = 0.03 * ExistingBalance;
			Console.WriteLine("No interest on this account..");
		}
	}
}
