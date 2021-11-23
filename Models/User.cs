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
        public static double balance { get; set; }
        public static double money = 0.0;

        //Constructor
        public User(double _balance)
        {
            money = _balance;
        }

        // --------------------------------------- WRITE AND READ FILES FROM CUSTOMER

        // Write Customer File
        public static void WriteCustomerFile(string customerDetails2, string firstName, string lastName, string email)
        {            
            string path = "C:/Users/pgmar/source/repos/BankingApplication/BankFiles/Customer/";
            string fileToWrite = $"{ path }/customer.txt";

            string[] customerDetails = { "Account Number: "+ customerDetails2 + " First Name: " + firstName + " Last Name: " + lastName + " Email: "+ email };

            // write try and catch here
            using (StreamWriter sw = new StreamWriter(fileToWrite, true))
            {
                foreach (string s in customerDetails)
                {
                    sw.WriteLine(s);
                }
            }
        }

        // It shows the list of All Customers
        public static void ReadCustomerFile()
        {
            string line = "";
            using (StreamReader sr = new StreamReader("C:/Users/pgmar/source/repos/BankingApplication/BankFiles/Customer/customer.txt"))
            {
                Console.WriteLine("\nList of all Customers:");
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        // Write Saving File
        public static void WriteSavingsFileAcc(string customerDetails2)
        {
            string savingsAccFile = $"{ customerDetails2 }-saving.txt";

            string[] customerSavingAcc = { DateTime.Now.ToString("yyyy-MM-dd") + ":Transactions:Balance: "+ 0};

            WriteSavingsFile(savingsAccFile, customerSavingAcc);
        }
        
        // Write Saving File
        public static void WriteSavingsFile(string savingsAccFile, params string [] customerSavingAcc)
        {
            string path = "C:/Users/pgmar/source/repos/BankingApplication/BankFiles/Saving/";
            string fileToWrite = $"{ path }/{ savingsAccFile }-saving.txt";

            using (StreamWriter sw = new StreamWriter(fileToWrite, true))
            {
                foreach (string s in customerSavingAcc)   
                {
                    sw.WriteLine(s);
                }
            }
        }

        // Read Saving File
        public static void ReadSavingsFile(string accountCode)
        {
            string path = "C:/Users/pgmar/source/repos/BankingApplication/BankFiles/Saving/";
            string savingsAccountFile = $"{ accountCode }-saving.txt";
            string fileToWrite = $"{ path }/{ savingsAccountFile }";
            string line = "";

            using (StreamReader sr = new StreamReader(fileToWrite))
            {
                Console.WriteLine("\nList of Savings Account:");
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        // Write Saving File
        public static void WriteCurrentFileAcc(string customerDetails2)
        {
            string currentAccFile = $"{ customerDetails2 }/BankFiles/Current/-current.txt";

            string[] customerCurrentAcc = { DateTime.Now.ToString("yyyy-MM-dd") + ":Transactions:Balance" + 0};

            WriteCurrentFile(currentAccFile, customerCurrentAcc);
        }

        // Write Current File
        public static void WriteCurrentFile(string currentAccFile, params string[] customerDetails)
        {

            string path = "C:/Users/pgmar/source/repos/BankingApplication/BankFiles/Current/";
            string fileToWrite = $"{ path }/{ currentAccFile }-current.txt";

            using (StreamWriter sw = new StreamWriter(fileToWrite, true))
            {
                foreach (string s in customerDetails)
                {
                    sw.WriteLine(s);
                }
            }
        }

        // Read Current
        public static void ReadCurrentFile(string accountCode)
        {
            string path = "C:/Users/pgmar/source/repos/BankingApplication/BankFiles/Current/";
            string savingsAccountFile = $"{ accountCode }-current.txt";
            string fileToWrite = $"{ path }/{ savingsAccountFile }";
            string line = "";

            using (StreamReader sr = new StreamReader(fileToWrite))
            {
                Console.WriteLine("\nList of Savings Account:");
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        // It generate customer file name
        public static int GeneratingCustomerFileName(string findLetterAt)
        {
            string s1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string s2 = findLetterAt;
            int letterAt = s1.IndexOf(s2) + 1;
            return letterAt;
        }

        // --------------------------------------- END WRITE AND READ FILES FROM CUSTOMER


        // --------------------------------------- ADD AND SUBTRACT MONEY

        // This method add money to the user Saving Account file
        public static void AddMoneySaving(double amount, string accountCode)
        {

            string savingsAccountFile = $"{ accountCode }-saving.txt";
            double uptatedSavingsBalance = balance + amount;

            string path = "C:/Users/pgmar/source/repos/BankingApplication/BankFiles/Saving/";
            string fileToWrite = $"{ path }/{ savingsAccountFile }";

            string[] customerSavingAcc = {"Account Number: " + DateTime.Now.ToString("yyyy-MM-dd") + " | " + "Actual: $" + money + " | " + "Deposit: $" + uptatedSavingsBalance };
                                                                                        // ADD A GET PARA PEGAR O BALANCE E SOMAR COM AMOUNT
            using (StreamWriter sw = new StreamWriter(fileToWrite, true))
            {
                foreach (string s in customerSavingAcc)
                {
                    sw.WriteLine(s);
                }
            }
        }

        // This method add money to the user Current Account File
        public static void AddMoneyCurrent(double amount, string accountCode)
        {
            string savingsAccountFile = $"{ accountCode }-current.txt";
            double uptatedCurrentBalance = balance + amount;

            string path = "C:/Users/pgmar/source/repos/BankingApplication/BankFiles/Current/";
            string fileToWrite = $"{ path }/{ savingsAccountFile }";

            string[] customerSavingAcc = { "Account Number: " + DateTime.Now.ToString("yyyy-MM-dd") + " | " +"Deposit: $" + uptatedCurrentBalance };
            // ADD A GET PARA PEGAR O BALANCE E SOMAR COM AMOUNT
            using (StreamWriter sw = new StreamWriter(fileToWrite, true))
            {
                foreach (string s in customerSavingAcc)
                {
                    sw.WriteLine(s);
                }
            }
        }

        // This Method gets the last value added to the Saving Account
        public static double GetSavingsBalance(string accountCode)
        {
            string path = "C:/Users/pgmar/source/repos/BankingApplication/BankFiles/Saving/";
            string savingAccount = $"{ accountCode }-saving.txt";
            string loadSavingAcount = $"{ path }/{ savingAccount }";

            StreamReader sr = new StreamReader(loadSavingAcount);

            string[] savingData = File.ReadAllText(loadSavingAcount).Split("|");

            int finalPosition = savingData.Length - 1;

            double loadSavingBalance = double.Parse(savingData[finalPosition]);

            sr.Close();

            return loadSavingBalance;
        }

        // This Method gets the last value added to the Saving Account
        public static double GetCurrentBalance(string accountCode)
        {

            string path = "C:/Users/pgmar/source/repos/BankingApplication/BankFiles/Current/";
            string currentAccount = $"{ accountCode }-current.txt";
            string loadCurrentAcount = $"{ path }/{ currentAccount }";

            StreamReader sr = new StreamReader(loadCurrentAcount);

            string[] currentData = File.ReadAllText(loadCurrentAcount).Split("|");

            int finalPosition = currentData.Length - 1;

            double loadCurrentBalance = double.Parse(currentData[finalPosition]);

            sr.Close();

            return loadCurrentBalance;
        }

        // This method withdraw money to the user Saving Account file
        public static void WithdrawMoneySaving(double amount, string accountCode)
        {
            //double balanceAccount = GetSavingsBalance(accountCode);
            string savingsAccountFile = $"{ accountCode }-saving.txt";
            double uptatedSavingBalance = balance - amount;

            string path = "C:/Users/pgmar/source/repos/BankingApplication/BankFiles/Saving/";
            string fileToWrite = $"{ path }/{ savingsAccountFile }";

            string[] customerSavingAcc = { "Account Number: " + DateTime.Now.ToString("yyyy-MM-dd") + " | " + "Old Balance: $" + amount + " | " + " New balance: $" + uptatedSavingBalance };

            using (StreamWriter sw = new StreamWriter(fileToWrite, true))
            {
                foreach (string s in customerSavingAcc)
                {
                    sw.WriteLine(s);
                }
            }
        }

        // This method withdraw money to the user Saving Account file
        public static void WithdrawMoneyCurrent(double amount, string accountCode)
        {

        }

        // Class for adding money to users account
        public void AddingMoney(double amount, string accountCode)
        {
            // Animation reloading and atual value saved
            Console.WriteLine("-----------------------------");
            TextAnimation.AnimationTyping($"Wait...\n");
            Console.WriteLine($"${amount} added to your Account!");

            money += amount;
        }

        // Class for subtract money to users account
        public void SubtractingMoney(double amount)
        {
            // User cant withdraw from a negative balance
            if (amount <= 0 || amount > money)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Your ballance is 0 you can not withdraw.\n");

                Console.WriteLine("\n1. Add Money");
                Console.WriteLine("2. Back to Menu");
                Console.Write("Answer: ");
                int answer;
                int.TryParse(Console.ReadLine(), out answer);

                while (answer != 1 && answer != 2)
                {
                    Console.WriteLine($"{answer} does not exist! Try again (1-2)");
                    Console.Write("Answer: ");
                    answer = Convert.ToInt32(Console.ReadLine());
                }

                if (answer == 1)
                {
                    TextAnimation.AnimationTyping($"Wait...\n");
                    Console.Clear();
                    //Customer.AddMoney();
                }
                else if (answer == 2)
                {
                    TextAnimation.AnimationTyping($"Wait...\n");
                    Console.Clear();
                    Customer.DisplayMenu();
                }
                else
                {
                    Console.WriteLine("Something went wrong, try again!");
                }

            }
            else
            {
                money -= amount;

                // Animation reloading and atual value saved
                Console.WriteLine("-----------------------------");
                TextAnimation.AnimationTyping($"Wait...\n");
                Console.WriteLine($"${amount} has been subtracted from your Account!");
            }
        }

        // --------------------------------------- END ADD AND SUBTRACT MONEY

        //if(File.Exists(@"C:\test.txt"))
        //{
        //File.Delete(@"C:\test.txt");
        //}

    }
}
