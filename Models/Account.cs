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
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public double balance { get; set; }


        public Account()
        {

        }

        public double CheckingBalance()
        {
            return balance = 0;
        }

        public double AddMoney(double newBalance)
        {
            double total = balance + newBalance;
            return total;
        }

    }
}
