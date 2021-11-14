using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//22931 - Marcos Oliveira
namespace BankingApplication.Models
{
    public class Customer
    {

        //constructor
        public Customer()
        {

        }

        public static void DisplayMenu(string welcome)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| Dear Customer,             |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| 1. Retrieve Transaction    |");
            Console.WriteLine("| 2. Add Money               |");
            Console.WriteLine("| 3. Withdrawal              |");
            Console.WriteLine("| 4. Log out                 |");
            Console.WriteLine("|                            |");
            Console.WriteLine("-----------------------------");
            Console.Write("Answer: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            // Cant have the wrong answer
            while (answer != 1 && answer != 2 && answer != 3 && answer != 4)
            {
                Console.WriteLine($"{answer} does not exist! Try again (1-5)");
                Console.Write("Answer: ");
                answer = Convert.ToInt32(Console.ReadLine());

            }

            if (answer == 1)
            {
                RetrieveTransaction();
            } else if (answer == 2)
            {
                AddMoney();
            } else if (answer == 3)
            {
                SubtractMoney();
            } else
            {
                LogOut();
            }
        }

        //Retrieve Transaction Method
        public static void RetrieveTransaction()
        {
            Console.WriteLine("Transaction History Method");
        }

        //Add Money Method
        public static void AddMoney()
        {

            Account account = new Account();
            double balance = account.CheckingBalance();
            
            Console.WriteLine($"Your current balance is:  {balance}  \n");
            Console.Write("How much do you want to add to your account? \n");
            Console.Write("$ ");
            double addBalance = Convert.ToDouble(Console.ReadLine());
            
            //Animation reloading
            Console.WriteLine("----------------------");
            TextAnimation.AnimationTyping("Wait... \n");
            Console.WriteLine("Money Added!");

            // shows the actual balance
            double newBalance = account.AddMoney(addBalance);
            Console.WriteLine($"Your current balance is: {newBalance}. \n");

            // New menu with condicion
            Console.WriteLine("1. Back to Menu");
            Console.WriteLine("2. Add Money");
            Console.WriteLine("3. Log out");
            Console.Write("Answer: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            while (answer != 1 && answer != 2 && answer != 3)
            {
                Console.WriteLine($"{answer} does not exist! Try again (1-3)");
                Console.Write("Answer: ");
                answer = Convert.ToInt32(Console.ReadLine());
            }

            if (answer == 1)
            {
                Console.Clear();
                Customer.DisplayMenu("Menu");
            } else if (answer == 2)
            {
                Console.Clear();
                AddMoney();
            } else
            {
                Console.Clear();
                LogOut();
            }
        }

        //Subtract Money Method
        public static void SubtractMoney()
        {
            Console.WriteLine("Subtract Money Method");
        }

        //Log out of the system
        public static void LogOut()
        {
            Console.WriteLine("You have been logged out");
        }
    }
}
