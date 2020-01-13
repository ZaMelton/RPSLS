using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

            Console.Clear();
            Console.WriteLine("Hello, " + p1.name + ". Please choose your game type..\n");
            Console.WriteLine("Press 1 for Human vs. Human");
            Console.WriteLine("Press 2 for Human vs. Bot");

            gameTypeChoice = Console.ReadLine();
            Console.Clear();

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
                            Console.WriteLine();
                            Console.WriteLine($"Welcome to the Thunderdome, {p2.name}.");
                            Thread.Sleep(1300);
                            Console.Clear();
                            validInput = true;
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("You have chosen to play against Megamind... Good Luck..");
                            Console.WriteLine();
                            p2 = new Bot();
                            validInput = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid input..");
                            Console.WriteLine();
                            gameTypeChoice = Console.ReadLine();
                            break;
                        }
                }

            } while (!(validInput));

            return gameTypeChoice;
        }

        public string ChooseGameRounds()
        {
            int shortGame = 3;
            int mediumGame = 5;
            int longGame = 7;

            Console.WriteLine("How many rounds would you like to play?");
            Console.WriteLine($"1) Best of {shortGame}\n2) Best of {mediumGame}\n3) Best of {longGame}");
            string roundChoice = Console.ReadLine();

            bool validInput = false;
            do
            {
                switch (roundChoice)
                {
                    case "1":
                        {
                            Console.WriteLine($"You have chosen to play {shortGame} rounds.");
                            validInput = true;
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine($"You have chosen to play {mediumGame} rounds.");
                            validInput = true;
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine($"You have chosen to play {longGame} rounds.");
                            validInput = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please choose a valid input.");
                            break;
                        }
                }
            } while (!(validInput));

            return roundChoice;
        }

        public void PlayerOneWin()
        {
            Console.WriteLine($"Congrats {p1.name} you won this round!");
            p1.wins++;
            Console.WriteLine($"{p1.name} {p1.wins} - {p2.wins} {p2.name}");
            Console.ReadLine();
            Console.Clear();
        }

        public void PlayerTwoWin()
        {
            Console.WriteLine($"Congrats {p2.name} you won this round!");
            p2.wins++;
            Console.WriteLine($"{p1.name} {p1.wins} - {p2.wins} {p2.name}");
            Console.ReadLine();
            Console.Clear();
        }

        public void PlayGame()
        {
            int gameRounds = Int32.Parse(ChooseGameRounds());
            Console.Clear();

            do
            {
                string p1Choice = p1.ChooseGesture();
                Console.Clear();
                string p2Choice = p2.ChooseGesture();
                Console.Clear();

                Console.WriteLine($"{p1.name} chose: {p1Choice}\n{p2.name} chose: {p2Choice}");
                Console.WriteLine();

                if (p1Choice == p2Choice)
                {
                    Console.WriteLine("You tied!");
                }

                //if choice is rock, rock beats scissors and lizard, rock loses to Paper and Spock
                else if (p1Choice == "Rock")
                {
                    if (p2Choice == "Paper")
                    {
                        Console.WriteLine("Paper covers Rock!");
                        PlayerTwoWin();
                    }
                    else if (p2Choice == "Scissors")
                    {
                        Console.WriteLine("Rock crushes Scissors!");
                        PlayerOneWin();
                    }
                    else if (p2Choice == "Lizard")
                    {
                        Console.WriteLine("Rock smashes Lizard!");
                        PlayerOneWin();
                    }
                    else if (p2Choice == "Spock")
                    {
                        Console.WriteLine("Spock vaporizes Rock!");
                        PlayerTwoWin();
                    }
                }

                //if choice is paper, paper beats rock and spock, paper loses to Scissors and Lizard
                else if (p1Choice == "Paper")
                {
                    if (p2Choice == "Rock")
                    {
                        Console.WriteLine("Paper covers Rock!");
                        PlayerOneWin();
                    }
                    else if (p2Choice == "Scissors")
                    {
                        Console.WriteLine("Scissors cuts Paper!");
                        PlayerTwoWin();
                    }
                    else if (p2Choice == "Lizard")
                    {
                        Console.WriteLine("Lizard eats Paper");
                        PlayerTwoWin();
                    }
                    else if (p2Choice == "Spock")
                    {
                        Console.WriteLine("Paper disproves Spock");
                        PlayerOneWin();
                    }
                }

                //if choice is scissors, scissors beats paper and lizard, scissors loses to rock and spock
                else if (p1Choice == "Scissors")
                {
                    if (p2Choice == "Rock")
                    {
                        Console.WriteLine("Rock crushes Scissors!");
                        PlayerTwoWin();
                    }
                    else if (p2Choice == "Paper")
                    {
                        Console.WriteLine("Scissors cuts Paper!");
                        PlayerOneWin();
                    }
                    else if (p2Choice == "Lizard")
                    {
                        Console.WriteLine("Scissors decapitates Lizard!");
                        PlayerOneWin();
                    }
                    else if (p2Choice == "Spock")
                    {
                        Console.WriteLine("Spock smashes Scissors!");
                        PlayerTwoWin();
                    }
                }

                //if choice is lizard, lizard beats paper and spock, lizard loses to rock and scissors
                else if (p1Choice == "Lizard")
                {
                    if (p2Choice == "Rock")
                    {
                        Console.WriteLine("Rock smashes Lizard!");
                        PlayerTwoWin();
                    }
                    else if (p2Choice == "Paper")
                    {
                        Console.WriteLine("Lizard eats Paper!");
                        PlayerOneWin();
                    }
                    else if (p2Choice == "Scissors")
                    {
                        Console.WriteLine("Scissors decapitates Lizard!");
                        PlayerTwoWin();
                    }
                    else if (p2Choice == "Spock")
                    {
                        Console.WriteLine("Lizard poisons Spock!");
                        PlayerOneWin();
                    }
                }

                //if choice is spock, spock beats rock and scissors, spock loses to lizard and paper
                else if (p1Choice == "Spock")
                {
                    if (p2Choice == "Rock")
                    {
                        Console.WriteLine("Spock vaporizes Rock!");
                        PlayerOneWin();
                    }
                    else if (p2Choice == "Paper")
                    {
                        Console.WriteLine("Paper disproves Spock!");
                        PlayerTwoWin();
                    }
                    else if (p2Choice == "Lizard")
                    {
                        Console.WriteLine("Lizard poisons Spock!");
                        PlayerTwoWin();
                    }
                    else if (p2Choice == "Scissors")
                    {
                        Console.WriteLine("Spock smashes Scissors!");
                        PlayerOneWin();
                    }
                }
            } while (p1.wins < ((gameRounds / 2) + 1) && p2.wins < ((gameRounds / 2) + 1));

            if (p1.wins == ((gameRounds / 2) + 1))
            {
                Console.WriteLine($"{p1.name} wins!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{p2.name} wins!");
                Console.ReadLine();

            }
        }
    }
}
