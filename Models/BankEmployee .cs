using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankingApplication.Models.Driver;

//22931 - Marcos Oliveira
namespace BankingApplication.Models
{
    public class BankEmployee
    {
        public static string employeeName { get; set; }

        //Constructor
        public BankEmployee(string _employeeName)
        {
            employeeName = _employeeName;
        }

        // Login Employee
        public static void LoginEmployee()
        {
            string password = "A1234";

            Console.WriteLine("-----------------------------");
            Console.Write("Name: ");
            employeeName = Console.ReadLine();
            Console.Write("Password: ");
            string employeePassword = Console.ReadLine();
                        
            // Cant have the wrong answer
            while (employeePassword != password)
            {
                Console.WriteLine("Please, try again! \n");
                Console.Write("Password: ");
                employeePassword = Console.ReadLine();
            }

            // Simple animation
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Authenticating user");
            TextAnimation.AnimationTyping($"Wait...\n");

            //It is calling the Customer class
            Console.Clear();
            DisplayMenu();
        }

        public static void DisplayMenu()
        {
            Console.WriteLine($"Welcome {employeeName},");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| 1. Create Customer         |");
            Console.WriteLine("| 2. Delete Customer         |");
            Console.WriteLine("| 3. Create Transactions     |");
            Console.WriteLine("| 4. List of Customer        |");
            Console.WriteLine("| 5. Exit                    |");
            Console.WriteLine("-----------------------------");
            Console.Write("Answer: ");
            int answer;
            int.TryParse(Console.ReadLine(), out answer);


            // Cant have the wrong answer
            while (answer !=1 && answer != 2 && answer != 3 && answer != 4 && answer != 5)
            {
                Console.WriteLine($"{answer} does not exist! Try again (1-5)");
                Console.Write("Answer: ");
                int.TryParse(Console.ReadLine(), out answer);
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
            // Asking user details
            Console.Write("Enter your First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Email address: ");
            string email = Console.ReadLine();

            // Getting the first word of first name and last name and size 
            string lFirstName = firstName.Substring(0, 1);
            string lLastName = lastName.Substring(0, 1);
            int lenghtFullName = firstName.Length + lastName.Length;
            int firstPosition = User.GeneratingCustomerFileName(lFirstName);
            int secondPosition = User.GeneratingCustomerFileName(lLastName);

            string customerDetails2 = $"{lFirstName.ToUpper()}{lLastName.ToUpper()}-{lenghtFullName}-{firstPosition}-{secondPosition}";

            User.WriteSavingsFile(customerDetails2);
            User.WriteCurrentFile(customerDetails2);
            User.WriteCustomerFile(customerDetails2, firstName, lastName, email);

            // Animation reloading
            Console.WriteLine("-----------------------------");
            TextAnimation.AnimationTyping("Wait...\n");
            Console.WriteLine("User Created! \n");
            Console.WriteLine($"Accound Number: {customerDetails2}");
            Console.WriteLine($"Account PIN Number: {firstPosition}{secondPosition}"); //save it and just allow the user to log in with pin
            Console.WriteLine("-----------------------------");

            // New menu with condicion
            Console.WriteLine("\n1. Back to Menu");
            Console.WriteLine("2. Create a new user");
            Console.WriteLine("3. Show a customer list");
            Console.WriteLine("4. Exit");
            Console.Write("Answer: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            while (answer != 1 && answer != 2 && answer != 3 && answer != 4)
            {
                Console.WriteLine($"{answer} does not exist! Try again (1-3)");
                Console.Write("Answer: ");
                answer = Convert.ToInt32(Console.ReadLine());
            }

            if (answer == 1)
            {
                Console.Clear();
               DisplayMenu();
            }
            else if (answer == 2)
            {
                Console.Clear();
                CreateCustomers();
            }
            else if (answer == 3)
            {
                Console.Clear();
                User.ReadCustomerFile();
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
            
            Console.WriteLine("\nThis Delete Customers method is not working yet!\n");

            // New menu with condicion
            Console.WriteLine("1. Back to Menu");
            Console.WriteLine("2. Delete Other Customer");
            Console.WriteLine("3. Exit");
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
                DisplayMenu();
            }
            else if (answer == 2)
            {
                //Animation reloading
                Console.WriteLine("\nThis Delete Customers Method is not working yet!");
                TextAnimation.AnimationTyping("Returning...");
                Console.Clear();
                DisplayMenu();
            }
            else
            {
                Console.Clear();
                LogOut();
            }
        }

        // Create transactions(lodge, deposit) for each customer
        // You should be able to add and withdraw for a specified account
        public static void CreateTransactions()
        {
            Console.WriteLine("\nThis Create Transactions Method is not working yet!\n");

            // New menu with condicion
            Console.WriteLine("1. Back to Menu");
            Console.WriteLine("2. Create Other Transaction");
            Console.WriteLine("3. Exit");
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
                DisplayMenu();
            }
            else if (answer == 2)
            {
                //Animation reloading
                Console.WriteLine("\nThis Create Transactions Method is not working yet!");
                TextAnimation.AnimationTyping("Returning...");
                Console.Clear();
                DisplayMenu();
            }
            else
            {
                Console.Clear();
                LogOut();
            }
        }

        // List of customers including their balances in savings and current account
        public static void ListOfCustomers()
        {
            User.ReadCustomerFile();

            // New menu with condicion
            Console.WriteLine("\n1. Back to Menu");
            Console.WriteLine("2. List of Customers");
            Console.WriteLine("3. Exit");
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
                DisplayMenu();
            }
            else if (answer == 2)
            {
                Console.Clear();
                ListOfCustomers();
            }
            else
            {
                Console.Clear();
                LogOut();
            }
        }
        
        // Log out of the system
        public static void LogOut()
        {
            // Animation reloading
            Console.WriteLine("-----------------------------");
            TextAnimation.AnimationTyping("Bye...\n");
        }
    }
}
