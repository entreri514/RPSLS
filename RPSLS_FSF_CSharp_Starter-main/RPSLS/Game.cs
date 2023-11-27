using RPSLS.RPSLS_FSF_CSharp_Starter_main.RPSLS;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disporves Spock");
            Console.WriteLine("Spock vaporizes Rock\n");
            Console.WriteLine("You may play against the computer or a human opponent");
            Console.WriteLine("Best 3 out of 5 wins, excluding ties.");

        }

        public int ChooseNumberOfHumanPlayers(int numPlayers)
        {
            string userInput;
            Console.WriteLine("Please enter number of players <1> or <2>: ");
            userInput = Console.ReadLine();

            if (userInput != "1" && userInput != "2")
            {
                Console.WriteLine("Please enter <1> or <2>");
                numPlayers = ChooseNumberOfHumanPlayers(0);
            }
            else
            {
                numPlayers = int.Parse(userInput);
            }
            
            return numPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            Console.WriteLine("Enter name for Player 1: ");
            string playerName = Console.ReadLine();
            playerOne = new HumanPlayer(playerName);
            if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Enter name for Player 2: ");
                playerName = Console.ReadLine();
                playerTwo = new HumanPlayer(playerName);
            }
            else
            {
                playerTwo = new ComputerPlayer();
            }

            
        }

        public void CompareGestures(string plyrOneGesture, string plyrTwoGesture)
        {
            if (plyrOneGesture == plyrTwoGesture)
            {
                Console.WriteLine("A tie.");
            }
            else if (plyrOneGesture == "rock")
            {
                if (plyrTwoGesture == "scissors" || plyrTwoGesture == "lizard")
                {
                    Console.WriteLine(playerOne.name + " scores!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " scores!");
                    playerTwo.score++;
                }
            }
            else if (plyrOneGesture == "scissors")
            {
                if (plyrTwoGesture == "lizard" || plyrTwoGesture == "paper")
                {
                    Console.WriteLine(playerOne.name + " scores!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " scores!");
                    playerTwo.score++;
                }
            }
            else if (plyrOneGesture == "paper")
            {
                if (plyrTwoGesture == "rock" || plyrTwoGesture == "Spock")
                {
                    Console.WriteLine(playerOne.name + " scores!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " scores!");
                    playerTwo.score++;
                }
            }
            else if (plyrOneGesture == "lizard")
            {
                if (plyrTwoGesture == "paper" || plyrTwoGesture == "Spock")
                {
                    Console.WriteLine(playerOne.name + " scores!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " scores!");
                    playerTwo.score++;
                }
            }
            else if (plyrOneGesture == "Spock")
            {
                if (plyrTwoGesture == "rock" || plyrTwoGesture == "scissors")
                {
                    Console.WriteLine(playerOne.name + " scores!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine(playerTwo.name + " scores!");
                    playerTwo.score++;
                }
            }
        }

        public void DisplayGameWinner()
        {
            if (playerOne.score==3)
            {
                Console.WriteLine(playerOne.name + " wins!");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " wins!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            int numOfPlayers = ChooseNumberOfHumanPlayers(0);
            CreatePlayerObjects(0);
            while (playerOne.score < 3 && playerTwo.score < 3)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures(playerOne.chosenGesture, playerTwo.chosenGesture);
            }
            DisplayGameWinner();
        }
    }
}
