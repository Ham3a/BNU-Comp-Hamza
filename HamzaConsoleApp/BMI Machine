using System;
using System.Collections.Generic;
using System.Text;

namespace HamzaConsoleApp.Unit4
{
    /// <summary>
    /// This class will calculate the BMI
    /// of the user
    /// Author: Hamza Basharat
    /// </summary>
    class BMI
    {
        private double kg, height;
        /// <summary>
        /// This method will ask the user to enter their
        /// weight in kg and their height in metres
        /// </summary>
        public void GetDetails()
        {
            SimpleIO.WriteTitle("Body Mass Index Calculator", "4.4");

            Console.WriteLine("Please enter your weight (kg):");
            kg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your height (m): ");
            height = Convert.ToDouble(Console.ReadLine());

        }

        /// <summary>
        /// This method will take the user's
        /// input of their weight and height and 
        /// calculate their BMI. It will 
        /// display their BMI and tell them if they're
        /// under, normal or overweight.
        /// </summary>
        public void CalculateBMI()
        {
           double BMI = kg / (height * height);

            Console.WriteLine("Your BMI is: " + Math.Round(BMI, 2));
            Console.ReadKey();

            if (BMI < 18.5)
            {
                Console.WriteLine("Youre Underweight");
            }
            else if (BMI < 25)
            {
                Console.WriteLine("Youre weight is normal");
            }
            else if (BMI < 30)
            {
                Console.WriteLine("Youre overweight");
            }
            else if (BMI < 40)
            {
                Console.WriteLine("Youre obese");
            }
            else
            {
                Console.WriteLine("Youre severely obese");
            }
        }
    }
}
