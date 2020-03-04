using System;
using System.Collections.Generic;
using System.Text;

namespace CO453ClassConsoleApp.Unit5
{
    /// <summary>
    /// Task 5.1 and Task 5.3
    /// This class gets and displays an array of tournament 
    /// scores for an array of names of players
    /// Derek Peacock
    /// Modified by: Hamza Basharat
    /// </summary>
    public class Tournament
    {
        public const int MAXN_SCORES = 3;

        // Another way of initialising attributes
        private int[] scores;

        // not created yet
        private string[] names;

        /// <summary>
        /// Class Constructor (not needed)
        /// </summary>
        public Tournament()
        {
            scores = new int[MAXN_SCORES];
            names = new string[]
            {
                "Hamza",
                "Jim",
                "Nathan",
                "Tyler",
                "Pete",
                "Liam",
                "Kiran",
                "Beth",
                "Leah"
            };
        }

        public void GetScores()
        {
            SimpleIO.WriteTitle("Enter Tournament Scores", "Task 5.1");

            for (int index = 0; index < MAXN_SCORES; index++)
            {
                Console.Write("Enter score for player " + (index + 1) + " > ");
                scores[index] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void GetDetails()
        {
            SimpleIO.WriteTitle("Enter Tournament Scores", "Task 5.1");

            for (int index = 0; index < MAXN_SCORES; index++)
            {
                Console.Write("Enter name for player " + (index + 1) + " > ");
                names[index] = Console.ReadLine();

                Console.Write("Enter score for player " + (index + 1) + " > ");
                scores[index] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void ShowScores()
        {
            SimpleIO.WriteTitle("Show Tournament Scores", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.WriteLine("Player " + (i + 1) + " scored " + scores[i]);
            }
        }
        public void ShowDetails()
        {
            SimpleIO.WriteTitle("Show Tournament Scores", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.WriteLine("Player " + names[i] + " scored " + scores[i]);
            }
        }
    }
}
