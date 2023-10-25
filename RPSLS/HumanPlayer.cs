using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.RPSLS_FSF_CSharp_Starter_main.RPSLS
{
    public class HumanPlayer : Player
    {


        public HumanPlayer(string playerOneName) : base("Player One")
        {

        }

        public override void ChooseGesture()
        {
            Console.WriteLine(gestures);
            Console.WriteLine("Please choose a gesture: ");
            chosenGesture = Console.ReadLine();
            if (chosenGesture != "rock" & chosenGesture != "paper" & chosenGesture != "scissors" & chosenGesture != "lizard" & chosenGesture != "Spock")
            {
                {
                    Console.WriteLine("Try again.");
                }
            }
        }
    }
}