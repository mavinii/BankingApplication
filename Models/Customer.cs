using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    class Customer
    {
        //1.	To login, a customer must enter their name, account code AND a pin number for their account
        //2.	A customer can retrieve the transaction history for their specified account.
        //3.	They can add and subtract money to either their savings account or current account.
        //4.	They cannot have negative balances

        private string _name;

        //constructor
        public Customer(string name)
        {
            _name = name;
        }

        //Retrieve Transaction Method
        public string retrieveTransaction()
        {
            return "Function retrieve the Transaction";
        }

        //History Account Method
        public string historyAccount()
        {
            return "Function history for their Specified Account";
        }

        //Add Money Method
        public string addMoney()
        {
            return "Function history for their Specified Account";
        }

        //Subtract Money method
        public string subtractMoney()
        {
            return "Function subtractMoney Specified Account";
        }

        //Negative balances
        public string negativeBalances()
        {
            return "Cannot have negative balances";
        }
    }
}
