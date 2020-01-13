using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Player
    {
        public string name;
        public List<string> gestureOptions = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        public abstract string ChooseGesture();
    }
}
