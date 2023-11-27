using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.RPSLS_FSF_CSharp_Starter_main.RPSLS
{
     public class ComputerPlayer:Player
    {
        Random rand;  

        public ComputerPlayer() : base("Computer")
            
        {
            rand = new Random();
        }

        public override void ChooseGesture()
        {
            chosenGesture = gestures[rand.Next(gestures.Count)];
        }

    }
}
