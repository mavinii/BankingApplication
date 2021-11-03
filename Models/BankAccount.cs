using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    public class BankAccount
    {

        //list of customer
        public List<string> listOfCustomer = new List<string>();

        public string customerFName { get; set; }
        public string customerLName { get; set; }
        public string customerEmail { get; set; }


        public BankAccount(string _customerFName, string _customerLName, string _customerEmail)
        {
            customerFName = _customerFName;
            customerLName = _customerLName;
            customerEmail = _customerEmail;
        }

        public BankAccount()
        {
        }

        internal void AddRange(List<string> list)
        {
            throw new NotImplementedException();
        }
    }
}
