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
        public List<string> gestureOptions = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };

        public abstract string ChooseGesture();
    }
}
