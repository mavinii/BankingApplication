using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    public class Customer
    {
        //1.	To login, a customer must enter their name, account code AND a pin number for their account
        //2.	A customer can retrieve the transaction history for their specified account.
        //3.	They can add and subtract money to either their savings account or current account.
        //4.	They cannot have negative balances


        //constructor
        public Customer()
        {
        }

        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| Customer,                  |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| 1. Retrieve Transaction    |");
            Console.WriteLine("| 2. Cash Deposit            |");
            Console.WriteLine("| 3. Withdrawal              |");
            Console.WriteLine("|                            |");
            Console.WriteLine("-----------------------------");

            Console.Write("Answer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                RetrieveTransaction();
            } else if (a == 2)
            {
                AddMoney();
            } else if (a == 3)
            {
                SubtractMoney();
            } else
            {
                Console.WriteLine("Wrong option, try again!");
            }
        }

        //Retrieve Transaction Method
        public void RetrieveTransaction()
        {
            Console.WriteLine("Transaction History Method");
        }

        //Add Money Method
        public void AddMoney()
        {
            Console.WriteLine("Add money Method");
        }

        //Subtract Money Method
        public void SubtractMoney()
        {
            Console.WriteLine("Subtract Money Method");
        }

        //Negative balances Method
        public void NegativeBalances()
        {
            Console.WriteLine("Cannot have negative balances Method");
        }
    }
}
