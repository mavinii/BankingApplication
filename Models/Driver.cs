using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//22931 - Marcos Oliveira
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
        public void Login(string name)
        {

            // Checking password
            String password = "A1234";
            int pin = 12345;
            string firstName;
            string secondName;
            
            Console.WriteLine("1. Bank Employee");
            Console.WriteLine("2. Customer");
            Console.Write("Answer: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            // Cant have the wrong answer
            while (answer != 1 && answer != 2)
            {
                Console.WriteLine($"{answer} does not exist! Try again (1-2) \n");
                Console.WriteLine("1. Bank Employee");
                Console.WriteLine("2. Customer");
                Console.Write("Answer: ");
                answer = Convert.ToInt32(Console.ReadLine());
            }

            if (answer == 1) 
            {
                Console.Write("Hi Employee, please type your password: ");
                string aEmployee = Console.ReadLine();

                // Cant have the wrong answer
                while (aEmployee != password) 
                {
                    Console.WriteLine("Please, try again! \n");
                    Console.Write("Password: ");
                    aEmployee = Console.ReadLine();
                }

                //It is calling the Customer class
                Console.WriteLine("Welcome, Employee!");
                BankEmployee.DisplayMenu("");
                
            } else if (answer == 2)
            {
                Console.WriteLine("\nHi Customer,");
                Console.Write("Firt Name: ");
                firstName = Console.ReadLine();
                Console.Write("Second Name: ");
                secondName = Console.ReadLine();
                Console.Write("Please, type your PIN: ");
                int customerPin = Convert.ToInt32(Console.ReadLine());

                // Cant have the wrong answer
                while (customerPin != pin)
                {
                    Console.WriteLine("Please, try again!");
                    Console.Write("Password: ");
                    customerPin = Convert.ToInt32(Console.ReadLine());
                }

                //It is calling the Customer class
                Customer.DisplayMenu($"Welcome {firstName} {secondName},");                
            }
        }
    }
}
