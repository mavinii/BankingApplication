using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    class BankEmployee
    {
        //1.	As a bank employee you can create and delete customers.
        //2.	Each new customer gets a savings account and a current account.
        //3.	You can only delete customers who have zero balances.
        //4.	You can create transactions(lodge, deposit) for each customer.You should be able to add and withdraw for a specified account.
        //5.	To create a customer account you need first name, last name and email.
        //6.	You should be able to show a complete list of customers including their balances in savings and current account.
        //7.	There should be a menu item allowing you to list customers, their account numbers.

        private string _name;

        //Constructor
        public BankEmployee(string name)
        {
            _name = name;
        }

        //5.To create a customer account you need first name, last name and email.
        public string CreateCustomers()
        {
            return "To create a customer account you need first name, last name and email";
        }

        //You can only delete customers who have zero balances.
        public string DeleteNegativeCustomers()
        {
            return "Customers 0 balances Method";
        }

        //Create transactions(lodge, deposit) for each customer
        //You should be able to add and withdraw for a specified account
        public string CreateTransactions()
        {
            return "Create transactions(lodge, deposit) for each customer." +
                   " You should be able to add and withdraw for a specified account";
        }


        //list of customers including their balances in savings and current account
        public string ListOfCustomers()
        {
            return "List of customers including their balances in savings and current account";
        }

        //menu item allowing you to list customers, their account numbers
        public string MenuCustomersList()
        {
            return "Menu item allowing you to list customers, their account numbers";
        }
    }
}
