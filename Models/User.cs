using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//22931 - Marcos Oliveira
namespace BankingApplication.Models
{
    public class User
    {

        // Constructor
        public User()
        {

        }

        // This Method creates an empty customer.txt for the first time 
        public static void FileEmpty()
        {
            string file = "customers.txt";
            string[] userDetails = Array.Empty<string>();
            WriteFile(file, userDetails);
        }

        // Method to get all user inf and add it to the .txt file 
        public static void ReadFile(string customerFName, string customerLName, string customerEmail)
        {
            string path = "customers.txt";
            string[] user = { customerFName, customerLName, customerEmail };

            WriteFile(path, user);
        }

        // This Method writes the user details
        public static void WriteFile(string file, string[] userDetails)
        {
                          // Change it in your pc address
            string path = "C:/Users/pgmar/source/repos/BankingApplication/Files/";
            string fileToWrite = $"{ path }/{ file }";

            try
            {
                using (StreamWriter sw = new StreamWriter(fileToWrite, true))
                {
                    foreach (string customer in userDetails)
                    {
                        sw.WriteLine(customer);
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine($"The {fileToWrite} file cound not be written.");
                Console.WriteLine(e.Message);
            }
        }

        // This Method deletes Customer 
        public static void DeleteCustomers()
        {

        }

        // This Method creates savings for the Customer
        public static void CreateSavingsAcc()
        {
            
        }

        // This Method lists all Customers
        public static void ListOfCustomers()
        {
            
        }

        // This Method log out the BankEmployee
        public static void LogOutBankEmployee()
        {

        }

        /*** Customer ***/

        // This Method Retrieve
        public static void RetrieveTransaction()
        {

        }

        // This Method Subtract money to the users Account
        public static void SubtractMoney()
        {

        }

        // This Method log out the Customer
        public void LogOutCustomer()
        {

        }
    }
}
