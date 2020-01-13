using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        Player p1;
        Player p2;
        string gameTypeChoice;

        public string ChooseGameType()
        {
            Console.WriteLine("Welcome to the Thunderdome!!! Let's play a game..");
            Console.WriteLine("What is your name?");
            string p1Name = Console.ReadLine();
            p1 = new Human(p1Name);

            Console.WriteLine("Hello, " + p1.name + ". Please choose your game type..");
            Console.WriteLine("Press 1 for Human vs. Human");
            Console.WriteLine("Press 2 for Human vs. Bot");

            gameTypeChoice = Console.ReadLine();

            bool validInput = false;

            do
            {
                switch (gameTypeChoice)
                {
                    case "1":
                        {
                            Console.WriteLine("What is the second player's name?");
                            string p2Name = Console.ReadLine();
                            p2 = new Human(p2Name);
                            validInput = true;
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("You have chosen to play against Megamind... Good Luck..");
                            p2 = new Bot();
                            validInput = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid input..");
                            gameTypeChoice = Console.ReadLine();
                            break;
                        }
                }

            } while (!(validInput));

            return gameTypeChoice;
        }

        public void PlayGame()
        {
            string gameType = ChooseGameType();

            if (gameType == "1")
            {
                string p1Choice = p1.ChooseGesture();
                Console.Clear();
                string p2Choice = p2.ChooseGesture();
                Console.Clear();

                if (p1Choice == p2Choice)
                {
                    Console.WriteLine("You tied!");
                    Console.ReadLine();
                }

                //if choice is rock, rock beats scissors and lizard
                else if (p1Choice == "Rock")
                {
                    if (p2Choice == "Scissors")
                    {
                        Console.WriteLine($"Congrats {p1.name} you won this round!");
                        Console.WriteLine("Rock crushes Scissors!");
                        Console.ReadLine();
                    }
                    else if (p2Choice == "Lizard")
                    {
                        Console.WriteLine($"Congrats {p1.name} you won this round!");
                        Console.WriteLine("Rock smashes Lizard!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Congrats {p2.name} you won this round!");
                        Console.WriteLine($"{p2Choice} beats {p1Choice}");
                        Console.ReadLine();
                    }
                }

                //if choice is paper, paper beats rock and spock
                else if (p1Choice == "paper")
                {
                    if (p2Choice == "Rock")
                    {
                        Console.WriteLine($"Congrats {p1.name} you won this round!");
                        Console.WriteLine("Paper covers rock!");
                        Console.ReadLine();
                    }
                    else if (p2Choice == "Spock")
                    {
                        Console.WriteLine($"Congrats {p1.name} you won this round!");
                        Console.WriteLine("Paper disproves Spock!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Congrats {p2.name} you won this round!");
                        Console.WriteLine($"{p2Choice} beats {p1Choice}");
                        Console.ReadLine();
                    }
                }

                //if choice is scissors, scissors beats paper and lizard
                else if (p1Choice == "Scissors")
                {
                    if (p2Choice == "Paper")
                    {
                        Console.WriteLine($"Congrats {p1.name} you won this round!");
                        Console.WriteLine("Scissors cuts Paper!");
                        Console.ReadLine();
                    }
                    else if (p2Choice == "Lizard")
                    {
                        Console.WriteLine($"Congrats {p1.name} you won this round!");
                        Console.WriteLine("Scissors decapitates Lizard!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Congrats {p2.name} you won this round!");
                        Console.WriteLine($"{p2Choice} beats {p1Choice}");
                        Console.ReadLine();
                    }
                }

                //if choice is lizard, lizard beats paper and spock
                else if (p1Choice == "Lizard")
                {
                    if (p2Choice == "Paper")
                    {
                        Console.WriteLine($"Congrats {p1.name} you won this round!");
                        Console.WriteLine("Lizard eats Paper!");
                        Console.ReadLine();
                    }
                    else if (p2Choice == "Spock")
                    {
                        Console.WriteLine($"Congrats {p1.name} you won this round!");
                        Console.WriteLine("Lizard poisons Spock!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Congrats {p2.name} you won this round!");
                        Console.WriteLine($"{p2Choice} beats {p1Choice}");
                        Console.ReadLine();
                    }
                }

                //if choice is spock, spock beats rock and scissors
                else if (p1Choice == "Spock")
                {
                    if (p2Choice == "Rock")
                    {
                        Console.WriteLine($"Congrats {p1.name} you won this round!");
                        Console.WriteLine("Spock vaporizes Rock!");
                        Console.ReadLine();
                    }
                    else if (p2Choice == "Scissors")
                    {
                        Console.WriteLine($"Congrats {p1.name} you won this round!");
                        Console.WriteLine("Spock breaks Scissors!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Congrats {p2.name} you won this round!");
                        Console.WriteLine($"{p2Choice} beats {p1Choice}");
                        Console.ReadLine();
                    }
                }
            }
        }

        /////////////////////////////////////////Will maybe use later/////////////////////////////////
        //public void WinMessage()
        //{
        //    Console.WriteLine("Congrats " + p1.name + " you won this round!");
        //    Console.WriteLine("Lizard poisons Spock!");
        //    Console.ReadLine();
        //}
    }
}
