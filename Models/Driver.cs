using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//22931 - Marcos Oliveira
namespace BankingApplication.Models
{
    // This class is in charge of main application
    public class Driver
    {

        private String password = "A1234";
        private int pin = 12345;

        // Method Bank Employee or Customer
        public Driver()
        {
            Console.WriteLine("**** Banking Application ****\n");

            Console.WriteLine("1. Bank Employee");
            Console.WriteLine("2. Customer");
            Console.Write("Answer: ");
            int answer;
            int.TryParse(Console.ReadLine(), out answer);


            // Cant have the wrong answer
            while (answer != 1 && answer != 2)
            {
                Console.WriteLine($"{answer} does not exist! Try again (1-2) \n");
                Console.WriteLine("1. Bank Employee");
                Console.WriteLine("2. Customer");
                Console.Write("Answer: ");
                int.TryParse(Console.ReadLine(), out answer);
            }

            if (answer == 1)
            {
                LoginEmployee("");
            } else if (answer == 2)
            {
                LoginCustomer("");
            } else
            {
                Console.WriteLine("Something went wrong, try again!");
            }
        }

        // Login Employee
        public void LoginEmployee(string name)
        {             
                Console.WriteLine("------------");
                Console.Write("Name: ");
                string employeeName = Console.ReadLine();
                Console.Write("Password: ");
                string employeePassword = Console.ReadLine();

                // Cant have the wrong answer
                while (employeePassword != password) 
                {
                    Console.WriteLine("Please, try again! \n");
                    Console.Write("Password: ");
                    employeePassword = Console.ReadLine();
                }

                //It is calling the Customer class
                Console.Clear();
                Console.WriteLine($"Welcome {employeeName},");
                BankEmployee.DisplayMenu("");
        }

        // Login Customer
        public void LoginCustomer(string name)
        {
            Console.WriteLine("------------");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Second Name: ");
            string secondName = Console.ReadLine();
            Console.Write("Please, type your PIN: ");
            int customerPin;
            int.TryParse(Console.ReadLine(), out customerPin);

            // Cant have the wrong answer
            while (customerPin != pin)
            {
                Console.WriteLine("Please, try again!");
                Console.Write("Password: ");
                customerPin = Convert.ToInt32(Console.ReadLine());
            }

            //It is calling the Customer class
            Console.Clear();
            Console.WriteLine($"Welcome {firstName} {secondName},");
            Customer.DisplayMenu("");
        }
    }
}
