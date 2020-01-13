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
            Console.WriteLine(name + ", Please choose an option: ");

            int optionNum = 1;
            foreach (String option in gestureOptions)
            {
                Console.WriteLine($"{optionNum}) {option}");
                optionNum++;
            }

            string playerChoice;
            bool validInput = false;

            do
            {
                playerChoice = Console.ReadLine().ToLower();
                switch (playerChoice)
                {
                    case "1":
                        {
                            playerChoice = gestureOptions[0];
                            validInput = true;
                            break;
                        }
                    case "2":
                        {
                            playerChoice = gestureOptions[1];
                            validInput = true;
                            break;
                        }
                    case "3":
                        {
                            playerChoice = gestureOptions[2];
                            validInput = true;
                            break;
                        }
                    case "4":
                        {
                            playerChoice = gestureOptions[3];
                            validInput = true;
                            break;
                        }
                    case "5":
                        {
                            playerChoice = gestureOptions[4];
                            validInput = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid input..");
                            playerChoice = Console.ReadLine();
                            break;
                        }
                }
            } while (!(validInput));

            return playerChoice;
        }
    }
}

