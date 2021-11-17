using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankingApplication.Models.Account;

//22931 - Marcos Oliveira
namespace BankingApplication.Models
{
    public class Customer
    {
        public string firstName;
        public string lastName;
        public int pinNumber;
        public int accountCode;
        public int enterNumber;
        public string email;
        public static Account account1 = new Account(0);
   

        public Customer(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }


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
                Console.WriteLine($"{answer} does not exist! Try again (1-4)");
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
            Console.WriteLine("\nThis Retrieve Transaction class is not working yet!\n");

            // New menu with condition
            Console.WriteLine("1. Back to Menu");
            Console.WriteLine("2. Subtract Money");
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
            }
            else if (answer == 2)
            {
                Console.Clear();

                //Animation reloading
                Console.WriteLine("\nThis Retrieve Transaction class is not working yet!\n");
                Console.WriteLine("----------------------");
                TextAnimation.AnimationTyping("Returning...");
                Customer.DisplayMenu("Menu");

                //RetrieveTransaction();
            }
            else
            {
                Console.Clear();
                LogOut();
            }
        }

        //Add Money Method
        public static void AddMoney()
        {

            //what is happening? I can add money but it is returning the actual value
            // and not adding they together


            
            // Asking how much money to add
            Console.WriteLine("How much do you want to add to your account?");
            double addBalance = Convert.ToDouble(Console.ReadLine());
            account1.AddingMoney(addBalance);

            // Animation reloading
            Console.WriteLine("----------------------");
            TextAnimation.AnimationTyping("Wait...\n");
            Console.WriteLine("Money Added!");

            // shows the actual balance
            Console.Write("Your current balance is: " + account1.getInfo());
            Console.WriteLine("\n----------------------\n");


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
            }
            else if (answer == 2)
            {
                Console.Clear();
                account1.getInfo();
                AddMoney();
            }
            else
            {
                Console.Clear();
                LogOut();
            }
        }

        //Subtract Money Method
        public static void SubtractMoney()
        {
            Console.WriteLine("This method should Subtract Money from a account \n");

            // New menu with condicion
            Console.WriteLine("1. Back to Menu");
            Console.WriteLine("2. Subtract Money");
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
            }
            else if (answer == 2)
            {
                Console.Clear();

                //Animation reloading
                Console.WriteLine("\nThis Subtract Money class is not working yet!\n");
                Console.WriteLine("----------------------");
                TextAnimation.AnimationTyping("Returning...");
                Customer.DisplayMenu("Menu");

                //SubtractMoney();
            }
            else
            {
                Console.Clear();
                LogOut();
            }
        }

        //Log out of user
        public static void LogOut()
        {
            Console.WriteLine("\nThis Log Out class is not working yet!\n");
            
            //Animation reloading
            Console.WriteLine("----------------------");
            TextAnimation.AnimationTyping("Returning...");
            Console.Clear();
            Customer.DisplayMenu("Menu");
        }
    }
}
