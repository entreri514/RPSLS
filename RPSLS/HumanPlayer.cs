using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.RPSLS_FSF_CSharp_Starter_main.RPSLS
{
    public class HumanPlayer : Player
    {


        public HumanPlayer(string name) : base(name)
        {

        }

        public override void ChooseGesture()
        {
            int flag = 0;
            do
            {
                if (flag > 0)
                {
                    Console.WriteLine("Try again.");
                }
                Console.WriteLine("Please choose a gesture: ");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{gestures[i]}");
                }
                Console.WriteLine();
                chosenGesture = Console.ReadLine();
                flag++;
            } while (chosenGesture != "rock" && chosenGesture != "paper" && chosenGesture != "scissors" && chosenGesture != "lizard" && chosenGesture != "Spock");
            
                
                
        }
        
    }
}