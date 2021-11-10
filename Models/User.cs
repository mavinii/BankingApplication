using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    public class User
    {
        //Create Customer
        public static void ReadFile(string file = "user.txt")
        {
            string path = "C:/Users/pgmar/Downloads";
            string fileToRead = $"{path}/{file}";

            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {
                    string line;

                    while ((line = sr.ReadLine()) is not null)
                    {
                        string[] splitData = line.Split(":");

                        string userName = String.Format("{0,-10}", splitData[0]);
                        Console.WriteLine($"{userName}\t{splitData[1]}");
                    }

                    //Animation reloading
                    Console.WriteLine("");
                    TextAnimation.AnimationTyping("Wait...");
                    Console.WriteLine("");
                    Console.WriteLine("User created!");

                    //Mostrar o menu de novo ao adicionar um novo usuario
                    //BankEmployee.DisplayMenu(); ????
                }
            } catch (Exception e)
            {
                Console.WriteLine($"The {fileToRead} file could not be read:");
                Console.WriteLine(e.Message);
            }
            //User.OutputSeparator();
        }

        public static void WriteFile(string file, string[] user)
        {
            string path = "C:/Users/pgmar/Downloads";
            string fileToWrite = $"{path}/{file}";

            try
            {
                using (StreamWriter sw = new StreamWriter(fileToWrite))
                {
                    foreach (string _user in user)
                    {

                        sw.WriteLine(_user);
                    }
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine($"The {fileToWrite} file could not be written");
                Console.WriteLine(e.Message);
            }
        }

        //Delete Customer Class { }
    }
}
