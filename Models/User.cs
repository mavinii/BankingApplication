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
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public double balance { get; set; }

        //Constructor
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
        public static void ReadFile(string firstName, string lastName, string email)
        {
            string path = "customers.txt";
            string[] user = { firstName, lastName, email };
            Console.WriteLine(user);

            WriteFile(path, user);
        }

        // This Method writes the user details
        public static void WriteFile(string file, params string[] userDetails)
        {
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

        // This Method creates an empty savings.txt for the first time 
        public static void FileEmptySavings()
        {
            string file = "-saving.txt";
            string[] userSavingsDetails = Array.Empty<string>();
            WriteSavingsList(file, userSavingsDetails);
        }

        // Method that Read a list of Savings
        public static void ReadSavingsList(string firstName, string lastName, string email)
        {
            string path = "-saving.txt";
            string[] user = { firstName, lastName, email };
            Console.WriteLine(user);

            WriteSavingsList(path, user);
        }

        // Method that writes a list of Savings
        public static void WriteSavingsList(string file, params string[] userSavingsDetails)
        {
            string path = "C:/Users/pgmar/source/repos/BankingApplication/Files/";
            string fileToWrite = $"{ path }/{ file }";
            try
            {
                using (StreamWriter sw = new StreamWriter(fileToWrite, true))
                {
                    foreach (string customer in userSavingsDetails)
                    {
                        sw.WriteLine(customer);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"The {fileToWrite} file cound not be written.");
                Console.WriteLine(e.Message);
            }
        }

        // This Method creates an empty current.txt for the first time 
        public static void FileEmptyCurrent()
        {
            string file = "-current.txt";
            string[] userCurrentDetails = Array.Empty<string>();
            WriteCurrentList(file, userCurrentDetails);
        }

        // Method that Read a list of Current
        public static void ReadCurrentList(string firstName, string lastName, string email)
        {
            string path = "-saving.txt";
            string[] user = { firstName, lastName, email };
            Console.WriteLine(user);

            WriteCurrentList(path, user);
        }

        // Method that writes a list of Savings
        public static void WriteCurrentList(string file, params string[] userCurrentDetails)
        {
            string path = "C:/Users/pgmar/source/repos/BankingApplication/Files/";
            string fileToWrite = $"{ path }/{ file }";
            try
            {
                using (StreamWriter sw = new StreamWriter(fileToWrite, true))
                {
                    foreach (string customer in userCurrentDetails)
                    {
                        sw.WriteLine(customer);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"The {fileToWrite} file cound not be written.");
                Console.WriteLine(e.Message);
            }
        }

        //if(File.Exists(@"C:\test.txt"))
        //{
        //File.Delete(@"C:\test.txt");
        //}

        ////new code
        //public string GeneratingCustomerFileName()
        //{
        //    // manage handling lower cases as well as capitals
        //    char x1 = firstName.ElementAt(0); // get first character of each name and add concat it
        //    char x2 = lastName.ElementAt(0);
        //    string xx = x1 + "" + x2;
        //    string nn = (firstName.Length + lastName.Length).ToString(); // get length of both variables and convert it to string
        //    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVQXYZ";
        //    string yy = (alphabet.IndexOf(x1) + 1).ToString();
        //    string zz = (alphabet.IndexOf(x2) + 1).ToString();
        //    string filename = xx + "-" + nn + "-" + yy + "-" + zz;
        //    return filename;
        //}

        public void displayHistory(string accountType)
        {
            string path = @"oop-banking-application-CA\bin\Debug\net5.0\accounts";
            string readHistoryFile = $"{path}/{accountType}";
            try
            {
                using (StreamReader sr = new StreamReader(accountType))
                {

                }
            }
            catch (Exception e)
            {
                //Console.WriteLine($"The {fileToReadCustomer} file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
