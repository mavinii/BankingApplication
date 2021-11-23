using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankingApplication.Models.BankEmployee;
using static BankingApplication.Models.Customer;

//22931 - Marcos Oliveira
namespace BankingApplication.Models
{
    // This class is in charge of main application
    public class Driver
    {

        public Driver()
        {

        }

        // Method Bank Employee or Customer
        public void Menu()
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
                BankEmployee.LoginEmployee();
            } else if (answer == 2)
            {
                Customer.LoginCustomer();
            } else
            {
                Console.WriteLine("Something went wrong, try again!");
                TextAnimation.AnimationTyping($"Wait...\n");
                Console.Clear();
                Menu();
            }
        }
    }
}
