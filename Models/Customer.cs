using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankingApplication.Models.User;
using static BankingApplication.Models.Driver;

//22931 - Marcos Oliveira
namespace BankingApplication.Models
{
    public class Customer
    {
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string accountCode { get; set; }
        public string email;
        public static User money = new User(0);

        public Customer(string _firstName, string _lastName, string _email)
        {
            firstName = _firstName;
            lastName = _lastName;
            email = _email;
        }

        //constructor
        public Customer()
        {

        }

        // Method to get user info and call the Menu
        public static void LoginCustomer()
        {
            int pin = 12345;
            
            Console.WriteLine("-----------------------------");
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Second Name: ");
            lastName = Console.ReadLine();
            Console.Write("Account Code e.g XX-00-00-00: ");
            accountCode = Console.ReadLine();
            Console.Write("Please, type your PIN: ");
            int customerPin;
            int.TryParse(Console.ReadLine(), out customerPin);

            // Cant have the wrong answer
            while (customerPin != pin)
            {
                Console.WriteLine("Please, try again! \n");
                Console.Write("Password: ");
                customerPin = Convert.ToInt32(Console.ReadLine());
            }

            // Animation reloading and atual value saved
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Authenticating user");
            TextAnimation.AnimationTyping($"Wait...\n");

            //It is calling the Customer class
            Console.Clear();
            DisplayMenu();
        }

        // This Method display the Main Menu
        public static void DisplayMenu()
        {
            Console.WriteLine($"Welcome {firstName} {lastName},");
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("| 1. Retrieve Transaction    |");
            Console.WriteLine("| 2. Add Money               |");
            Console.WriteLine("| 3. Withdrawal              |");
            Console.WriteLine("| 4. Exit                    |");
            Console.WriteLine("-----------------------------");
            Console.Write("Answer: ");
            int answer;
            int.TryParse(Console.ReadLine(), out answer);

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
                AddMoney(accountCode);
            } else if (answer == 3)
            {
                SubtractMoney(accountCode);
            } else
            {
                LogOut();
            }
        }

        //Retrieve Transaction Method
        public static void RetrieveTransaction()
        {
            Console.WriteLine("\nThis Retrieve Transaction class is not working yet!");

            //Animation reloading
            Console.WriteLine("-----------------------------");
            TextAnimation.AnimationTyping("Returning...");
            Console.Clear();
            DisplayMenu();
        }

        //Add Money Method
        public static void AddMoney(string accountCode)
        {

            Console.WriteLine("\n1. Savings Account");
            Console.WriteLine("2. Current Account");
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
                Console.WriteLine("\nHow much do you want to add in your Saving Account:");
                Console.Write("Answer $");
                double addBalanceSaving = Convert.ToDouble(Console.ReadLine());

                //Animation reloading and atual value saved
                Console.WriteLine("-----------------------------");
                TextAnimation.AnimationTyping($"Wait...\n");
                Console.WriteLine($"Money added to your Saving Account!");

                // Adding money to the Method addingMoney in User class
                AddMoneySaving(addBalanceSaving, accountCode);

                // It shows the actual balance
                //Console.Write("Saving Account: $" + money.GetInfo() +"\n");


            } else if (answer == 2)
            {
                Console.WriteLine("\nHow much do you want to add in your Current Account:");
                Console.Write("Answer $");
                double addBalanceSaving = Convert.ToDouble(Console.ReadLine());

                // Animation reloading and atual value saved
                Console.WriteLine("-----------------------------");
                TextAnimation.AnimationTyping($"Wait...\n");
                Console.WriteLine($"Money added to your Current Account!");

                AddMoneyCurrent(addBalanceSaving, accountCode);

                // It shows the actual balance
                //Console.Write("Current Account: $" + money.GetInfo() + "\n");
            } else
            {
                Console.WriteLine("Wrong answer, try again!");
            }

            // New menu with condicion
            Console.WriteLine("\n1. Back to Menu");
            Console.WriteLine("2. Add Money");
            Console.WriteLine("3. See Savings Account");
            Console.WriteLine("4. See Current Account");
            Console.WriteLine("5. Exit");
            Console.Write("Answer: ");
            int answerMenu;
            int.TryParse(Console.ReadLine(), out answerMenu);

            while (answerMenu != 1 && answerMenu != 2 && answerMenu != 3 && answerMenu != 4 && answerMenu != 5)
            {
                Console.WriteLine($"{answerMenu} does not exist! Try again (1-5)");
                Console.Write("Answer: ");
                answerMenu = Convert.ToInt32(Console.ReadLine());
            }

            if (answerMenu == 1)
            {
                Console.Clear();
                DisplayMenu();
            }
            else if (answerMenu == 2)
            {
                AddMoney(accountCode);
            }
            else if(answerMenu == 3)
            {
                ReadSavingsFile(accountCode);
            }
            else if (answerMenu == 4)
            {
                ReadCurrentFile(accountCode);
            } else
            {
                Console.Clear();
                LogOut();
            }
        }

        //Subtract Money Method
        public static void SubtractMoney(string accountCode)
        {
            Console.WriteLine("\n1. Savings Account");
            Console.WriteLine("2. Current Account");
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
                Console.WriteLine("\nHow much do you want to Subtract from your Saving Account:");
                Console.Write("Answer $");
                double subtractBalance = Convert.ToDouble(Console.ReadLine());


                // Animation reloading and atual value saved
                Console.WriteLine("-----------------------------");
                TextAnimation.AnimationTyping($"Wait...\n");
                Console.WriteLine($"Money Subtracted from your Saving Account!");

                // Adding money to the Method addingMoney in User class
                WithdrawMoneySaving(subtractBalance, accountCode);


                //Console.Write("Saving Account: $" + money.GetInfo() + "\n");
            }
            else if (answer == 2)
            {
                Console.WriteLine("\nHow much do you want to Subtract from your Current Account:");
                Console.Write("Answer $");
                double subtractBalance = Convert.ToDouble(Console.ReadLine());

                money.SubtractingMoney(subtractBalance);

                //Console.Write("Current Account: $" + money.GetInfo() + "\n");
            }
            else
            {
                Console.WriteLine("Wrong answer, try again!");
            }

            // New menu with condicion
            Console.WriteLine("\n1. Back to Menu");
            Console.WriteLine("2. Add Money");
            Console.WriteLine("3. See Savings Account");
            Console.WriteLine("4. See Current Account");
            Console.WriteLine("5. Exit");
            Console.Write("Answer: ");
            int answerMenu;
            int.TryParse(Console.ReadLine(), out answerMenu);

            while (answerMenu != 1 && answerMenu != 2 && answerMenu != 3 && answerMenu != 4 && answerMenu != 5)
            {
                Console.WriteLine($"{answerMenu} does not exist! Try again (1-5)");
                Console.Write("Answer: ");
                answerMenu = Convert.ToInt32(Console.ReadLine());
            }

            if (answerMenu == 1)
            {
                Console.Clear();
                DisplayMenu();
            }
            else if (answerMenu == 2)
            {
                Console.Clear();
                //Console.Write("Your current balance is: $" + money.GetInfo() + "\n");
                AddMoney(accountCode);
            }
            else if (answerMenu == 3)
            {
                ReadSavingsFile(accountCode);
            }
            else if (answerMenu == 4)
            {
                ReadCurrentFile(accountCode);
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
            // Animation reloading
            Console.WriteLine("-----------------------------");
            TextAnimation.AnimationTyping("Bye...\n");
        }
    }
}
