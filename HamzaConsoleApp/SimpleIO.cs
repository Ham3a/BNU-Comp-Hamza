  
using System;
using System.Collections.Generic;
using System.Text;

namespace HamzaConsoleApp
{
 
    static class SimpleIO
    {
        public const string AUTHOR = "Hamza Basharat";

        public static void WriteTitle(string title, string task)
        {
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("  CO453 Class Exercises by " + AUTHOR);
            Console.WriteLine("  " + task + " " + title);
            Console.WriteLine("==========================================");
            Console.WriteLine();
        }

        /// <summary>
        /// This method displays a prompt for the user to enter a integer 
        /// value which is input as a string and converted to an int
        /// </summary>
        public static int GetInt(string prompt)
        {
            int mark;
            string input;

            Console.WriteLine();
            Console.Write(prompt);

            input = Console.ReadLine();
            mark = Convert.ToInt32(input);

            return mark;
        }

        /// <summary>
        /// This method displays a prompt for the user to enter a integer 
        /// value between and including min and max
        /// </summary>
        public static int GetInt(string prompt, int min, int max)
        {
            int mark;
            bool isValid = false;

            do
            {
                mark = GetInt(prompt);
                if (mark < min || mark > max)
                {
                    Console.WriteLine("Your value must be between " + min + " and " + max);
                }
                else isValid = true;

            } while (!isValid);

            return mark;
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter a integer value which is
        /// input as a string and converted to an int
        /// </summary>
        public static decimal GetDecimal(string prompt)
        {
            decimal amount;
            string input;

            Console.WriteLine();
            Console.Write(prompt);

            input = Console.ReadLine();
            amount = Convert.ToDecimal(input);

            return amount;
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter a integer value which is
        /// input as a string and converted to an int
        /// </summary>
        public static double GetDouble(string prompt)
        {
            double amount;
            string input;

            Console.WriteLine();
            Console.Write(prompt);

            input = Console.ReadLine();
            amount = Convert.ToDouble(input);

            return amount;
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter their name
        /// </summary>
        public static string GetString(string prompt)
        {
            string input;

            Console.WriteLine();
            Console.Write(prompt);

            input = Console.ReadLine();

            return input;
        }

        /// <summary>
        /// This method displays a menu of choices and the user
        /// can select one by entering a valid number 
        /// </summary>
        public static int GetChoice(string[] choices)
        {
            int choiceNo = 0;
            int noChoices = choices.Length;
            bool validChoice = false;

            while (!validChoice)
            {
                choiceNo = 0;
                Console.WriteLine();

                foreach (string choice in choices)
                {
                    choiceNo++;
                    Console.WriteLine("   " + choiceNo.ToString() + ": " + choice);
                }

                Console.WriteLine();
                Console.Write("Select one of the above (1 - " + noChoices + ") >");

                string value = Console.ReadLine();
                choiceNo = Convert.ToInt32(value);

                if (choiceNo < 1 || choiceNo > noChoices)
                {
                    Console.WriteLine();
                    Console.WriteLine(choiceNo.ToString() + " is not a valid choice!");
                    Console.WriteLine();
                }
                else
                {
                    validChoice = true;
                }
            }

            return choiceNo;
        }
    }
}
