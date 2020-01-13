using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Bot : Player
    {
        public Bot()
        {
            name = "Megamind";
        }

        public override string ChooseGesture()
        {
            Random random = new Random();
            int botChoice = random.Next(5);

            return gestureOptions[botChoice];
        }
    }
}
