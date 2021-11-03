using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    public class Driver
    {
        // This class is in charge of main application

        //Constructor
        public Driver()
        {
            Console.WriteLine("**** Banking Application ****");
            Console.WriteLine("");
        }

        // Function to know if it is Bank Employee or Customer
        public void Login()
        {

            // Checking password
            String password = "A1234";
            int pin = 12345;
            string firstName;
            string secondName;

            Console.WriteLine("1. Bank Employee");
            Console.WriteLine("2. Customer");
            Console.Write("Answer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if ((a != 1) && (a != 2)) 
            {
                Console.WriteLine("Please, try again!");
                
            } else if (a == 1) 
            {
                Console.Write("Hi Employee, please type your password: ");
                string aEmployee = Console.ReadLine();

                if (aEmployee != password) 
                {
                    Console.WriteLine("Please, try again!");
                } else 
                {
                    Console.WriteLine("Welcome, Employee!");

                    //It is calling the Customer class
                    BankEmployee bankemployee = new BankEmployee();
                    bankemployee.DisplayMenu();
                }
            } else if (a == 2)
            {
                Console.WriteLine("Hi Customer,");
                Console.Write("Firt Name: ");
                firstName = Console.ReadLine();
                Console.Write("Second Name: ");
                secondName = Console.ReadLine();
                Console.Write("Please, type your PIN: ");
                int customerPin = Convert.ToInt32(Console.ReadLine());

                if (customerPin != pin)
                {
                    Console.WriteLine("Please, try again!");
                }
                else
                {
                    Console.WriteLine($"Welcome {firstName} {secondName},");

                    //It is calling the Customer class
                    Customer customer = new Customer();
                    customer.DisplayMenu();
                }
            }
        }
    }
}
