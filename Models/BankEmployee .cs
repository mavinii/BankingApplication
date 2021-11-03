using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    class BankEmployee
    {
        

        //public object listOfCustomer { get; private set; }

        //1.	As a bank employee you can create and delete customers.
        //2.	Each new customer gets a savings account and a current account.
        //3.	You can only delete customers who have zero balances.
        //4.	You can create transactions(lodge, deposit) for each customer.You should be able to add and withdraw for a specified account.
        //5.	To create a customer account you need first name, last name and email.
        //6.	You should be able to show a complete list of customers including their balances in savings and current account.
        //7.	There should be a menu item allowing you to list customers, their account numbers.

        //Constructor
        public BankEmployee()
        {

        }

        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| Employee,                  |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| 1. Create Customer         |");
            Console.WriteLine("| 2. Delete Customer         |");
            Console.WriteLine("| 3. Create Transactions     |");
            Console.WriteLine("| 4. List of Customer        |");
            Console.WriteLine("|                            |");
            Console.WriteLine("-----------------------------");

            Console.Write("Answer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                CreateCustomers();
            } else if (a == 2)
            {
                DeleteCustomers();
            } else if (a == 3)
            {
                CreateTransactions();
            } else if (a == 4)
            {
                ListOfCustomers();
            }
            else
            {
                Console.WriteLine("Wrong option, try again!");
            }
        }

        //5.To create a customer account you need first name, last name and email.
        public void CreateCustomers()
        {
            BankAccount bankAccount = new BankAccount();

            //asking customer details
            Console.Write("Enter your First Name: ");
            string customerFName = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            string customerLName = Console.ReadLine();
            Console.Write("Email address: ");
            string customerEmail = Console.ReadLine();

            ///bankAccount.add(new BankAccount { customerFName, customerLName, customerEmail });
            //string[] newCustomer = { customerFName, customerLName, customerEmail };
            //listOfCustomer.Add(newCustomer);

            bankAccount.AddRange(new List<String>() { customerFName, customerLName, customerEmail });

            //BankAccount c1 = new BankAccount(customerFName, customerLName, customerEmail);
            //bankAccount.listOfCustomer.Add(c1);
            //bankAccount.listOfCustomer.Add( customerFName,  customerLName,  customerEmail);

            //Console.WriteLine( PRINT THE LIST HERE );

            //Create an user file to save all information here.

        }

        //You can only delete customers who have zero balances.
        public void DeleteCustomers()
        {
            //Create an user file to save all information here.
            Console.WriteLine("Customers 0 balances Method");
        }

        //Create transactions(lodge, deposit) for each customer
        //You should be able to add and withdraw for a specified account
        public void CreateTransactions()
        {
            Console.WriteLine("This is the Create transactions Method");
        }

        //list of customers including their balances in savings and current account
        public void ListOfCustomers()
        {
            Console.WriteLine("This is the list of customers Method");
        }
    }
}
