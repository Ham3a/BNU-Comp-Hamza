using System;
using System.Collections.Generic;
using System.Text;

namespace HamzaConsoleApp.RPS
{

    public enum RPS_Players
    {
        NONE,
        COMPUTER,
        PLAYER
    }

    public enum RPS_Choices
    {
        UNKNOWN,
        ROCK,
        PAPER,
        SCISSORS,
    }

    /// <summary>
    /// This class is the code for the game.
    /// Author: Derek
    /// Started: 12/02/2019
    /// Modified : 18/02/2020
    /// </summary>
    public class RPS_Game
    {
        public const string COMPUTER_NAME = "Computer";

        public int ComputerScore { get; set; }
        public int PlayerScore { get; set; }
        public string PlayerName { get; set; }

        public string WinnerName { get; set; }

        public RPS_Choices ComputerChoice { get; set; }
        public RPS_Choices PlayerChoice { get; set; }

        private Random randomGenerator = new Random(123);


        public void Start(string player)
        {
            PlayerName = player;
            WinnerName = "Unkown";

            PlayerScore = 0;
            ComputerScore = 0;

        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void End()
        {
        }

        /// <summary>
        /// This method will get the 
        /// computer's choice of rock,
        /// paper and scissors
        /// </summary>
        public void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);

            if (choice == 0)
            {
                ComputerChoice = RPS_Choices.ROCK;
            }
            else if (choice == 1)
            {
                ComputerChoice = RPS_Choices.PAPER;
            }
            else if (choice == 2)
            {
                ComputerChoice = RPS_Choices.SCISSORS;
            }
            else
            {
                ComputerChoice = RPS_Choices.UNKOWN;
            }
        }


        /// <summary>
        /// *******************************************************
        /// This method will determine whether the computer
        /// has won, or the player has won, or it is a draw.
        /// *******************************************************
        /// </summary>
        public void WorkoutWinner()
        {
           if (PlayerChoice == RPS_Choices.ROCK && ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.PAPER && ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.SCISSORS && ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.PAPER && ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.ROCK && ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.SCISSORS && ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;
            }
            else 
            {
                WinnerName = "You have Drawn!!!";
                ComputerScore++;
                PlayerScore++;
            }
        }
        
        /// <summary>
        /// This will compare the scores
        /// and output the images, either the 
        /// player or computer, and output the winner
        /// </summary>
        public void OverallWinner()
        {
            if (PlayerScore > ComputerScore)
            {
                Console.WriteLine("The winner is " + PlayerName);
                Images.DrawThumbsUp();
            }
            else if (ComputerScore > PlayerScore)
            {
                Console.WriteLine("The winner is " + COMPUTER_NAME);
                Images.DrawThumbsDown();
            }
            else
            {
                Console.WriteLine("It's a draw");
                Images.DrawSmile();
            }
        }
    }
}
