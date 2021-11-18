using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//22931 - Marcos Oliveira
namespace BankingApplication.Models
{
    public class Account
    {

        public double money = 0.0;

        // constructor
        public Account(double _balance)
        {
            money = _balance;
        }

        // class for adding money to users account
        public void AddingMoney(double amount)
        {
            Console.WriteLine($"Adding ${amount}");
            money += amount;   
        }

        // class for subtract money to users account
        public void SubtractingMoney(double _money)
        {
            Console.WriteLine($"Subtracting ${_money}");
            money -= _money;
        }

        // class for returning user info account
        public double getInfo()
        {
            return money;
        }
    }
}