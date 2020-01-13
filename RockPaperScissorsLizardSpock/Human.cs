using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
        }

        public override string ChooseGesture()
        {
            Console.WriteLine(name + ", Please choose Rock, Paper, Scissors, Lizard or Spock");
            string playerChoice = Console.ReadLine().ToLower();

            return playerChoice;
        }
    }
}
