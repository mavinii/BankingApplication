using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//22931 - Marcos Oliveira
namespace BankingApplication.Models
{
    public class BankEmployee
    {
 
        //Constructor
        public BankEmployee()
        {

        }

        public static void DisplayMenu(string welcome)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| Dear Employee,             |");
            Console.WriteLine("|                            |");
            Console.WriteLine("| 1. Create Customer         |");
            Console.WriteLine("| 2. Delete Customer         |");
            Console.WriteLine("| 3. Create Transactions     |");
            Console.WriteLine("| 4. List of Customer        |");
            Console.WriteLine("| 5. Log out                 |");
            Console.WriteLine("|                            |");
            Console.WriteLine("-----------------------------");
            Console.Write("Answer: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            // Cant have the wrong answer
            while (answer !=1 && answer != 2 && answer != 3 && answer != 4 && answer != 5)
            {
                Console.WriteLine($"{answer} does not exist! Try again (1-5)");
                Console.Write("Answer: ");
                answer = Convert.ToInt32(Console.ReadLine());

            }

            if (answer == 1)
            {
                CreateCustomers();
            } else if (answer == 2)
            {
                DeleteCustomers();
            } else if (answer == 3)
            {
                CreateTransactions();
            }else if (answer == 4)
            {
                ListOfCustomers();
            } else
            {
                LogOut();
            }
        }

        // This Method creates a new user
        public static void CreateCustomers()
        {
            //Asking customer details
            Console.Write("Enter your First Name: ");
            string customerFName = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            string customerLName = Console.ReadLine();
            Console.Write("Email address: ");
            string customerEmail = Console.ReadLine();

            //User.ReadFile(customerFName, customerLName, customerEmail);
            string newUser = "customers.txt";
            string[] userDetails = { "Name: " + customerFName + ", Last Name: " + customerLName + ", Email: " + customerEmail };
            User.WriteFile(newUser, userDetails);

            // Animation reloading
            Console.WriteLine("----------------------");
            TextAnimation.AnimationTyping("Wait... \n");
            Console.WriteLine("User Created! \n");

            // New menu with condicion
            Console.WriteLine("1. Back to Menu");
            Console.WriteLine("2. Create a new user");
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
                BankEmployee.DisplayMenu("Menu");
            }
            else if (answer == 2)
            {
                Console.Clear();
                CreateCustomers();
            }
            else
            {
                Console.Clear();
                LogOut();
            }
        }

        // You can only delete customers who have zero balances.
        public static void DeleteCustomers()
        {
            // Create an user file to save all information here.
            Console.WriteLine("Customers 0 balances Method");
        }

        // Create transactions(lodge, deposit) for each customer
        // You should be able to add and withdraw for a specified account
        public static void CreateTransactions()
        {
            Console.WriteLine("This is the Create transactions Method");
        }

        // List of customers including their balances in savings and current account
        public static void ListOfCustomers()
        {
            Console.WriteLine("List of Customers");
        }
        
        // Log out of the system
        public static void LogOut()
        {
            Console.WriteLine("You have been logged out");
        }
    }
}
