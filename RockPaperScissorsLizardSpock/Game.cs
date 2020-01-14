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

        public void ChooseGameType()
        {
            Console.WriteLine("What is your name?");
            string p1Name = Console.ReadLine();
            p1 = new Human(p1Name);

            Console.Clear();
            Console.WriteLine("Hello, " + p1.name + ". Please choose your game type..\n");
            Console.WriteLine("Press 1 for Human vs. Human");
            Console.WriteLine("Press 2 for Human vs. Bot");
            Console.WriteLine("Press 3 for Bot vs. Bot");

            gameTypeChoice = Console.ReadLine();
            Console.Clear();

            bool validInput = false;

            do
            {
                switch (gameTypeChoice)
                {
                    case "1":
                        Console.WriteLine("What is the second player's name?");
                        string p2Name = Console.ReadLine();
                        p2 = new Human(p2Name);
                        Console.WriteLine();
                        Console.WriteLine($"Welcome to the Thunderdome, {p2.name}.");
                        Thread.Sleep(1800);
                        Console.Clear();
                        validInput = true;
                        break;
                        
                    case "2":
                        Console.WriteLine("You have chosen to play against Megamind... Good Luck..");
                        Console.WriteLine();
                        p2 = new Bot("Megamind");
                        validInput = true;
                        break;
                        
                    case "3":
                        Console.WriteLine("You have chosen to watch the bots duel!");
                        p1 = new Bot("Megamind");
                        p2 = new Bot("C3P-0 Human Cyborg Relations");
                        validInput = true;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid input..");
                        Console.WriteLine();
                        gameTypeChoice = Console.ReadLine();
                        break;
                        
                }
            } while (!validInput);
        }

        public int ChooseGameRounds()//Better way to do this method?????
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
                            return shortGame;
                        }
                    case "2":
                        {
                            Console.WriteLine($"You have chosen to play {mediumGame} rounds.");
                            validInput = true;
                            return mediumGame;
                        }
                    case "3":
                        {
                            Console.WriteLine($"You have chosen to play {longGame} rounds.");
                            validInput = true;
                            return longGame;
                        }
                    default:
                        {
                            Console.WriteLine("Please choose a valid input.");
                            roundChoice = Console.ReadLine();
                            break;
                        }
                }
            } while (!(validInput));
            return 0;
        }

        public void PlayerWin(Player winner, Player loser)
        {
            Console.WriteLine($"Congrats {winner.name} you won this round!");
            winner.wins++;
            Console.WriteLine($"{p1.name} {p1.wins} - {p2.wins} {p2.name}");
            Console.ReadLine();
            Console.Clear();
        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to the Thunderdome!!! Let's play a game..");
            Console.WriteLine();
            Console.WriteLine("It's called Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("The rules are the same for your typical game of Rock, Paper, Scissors,");
            Console.WriteLine("except now there are two extra options: Spock and Lizard");
            Console.WriteLine("Spock will win against Rock and Scissors, but lose against Lizard and Paper.");
            Console.WriteLine("Lizard will win against Spock and Paper, but lose against Scissors and Rock.");
            Console.WriteLine("That's enought rules, let's play!");
            Console.WriteLine();
        }

        public void DetermineRoundWinner(string p1Choice, string p2Choice)
        {
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
                    PlayerWin(p2,p1);
                }
                else if (p2Choice == "Scissors")
                {
                    Console.WriteLine("Rock crushes Scissors!");
                    PlayerWin(p1,p2);
                }
                else if (p2Choice == "Lizard")
                {
                    Console.WriteLine("Rock smashes Lizard!");
                    PlayerWin(p1,p2);
                }
                else if (p2Choice == "Spock")
                {
                    Console.WriteLine("Spock vaporizes Rock!");
                    PlayerWin(p2,p1);
                }
            }

            //if choice is paper, paper beats rock and spock, paper loses to Scissors and Lizard
            else if (p1Choice == "Paper")
            {
                if (p2Choice == "Rock")
                {
                    Console.WriteLine("Paper covers Rock!");
                    PlayerWin(p1,p2);
                }
                else if (p2Choice == "Scissors")
                {
                    Console.WriteLine("Scissors cuts Paper!");
                    PlayerWin(p2,p1);
                }
                else if (p2Choice == "Lizard")
                {
                    Console.WriteLine("Lizard eats Paper");
                    PlayerWin(p2,p1);
                }
                else if (p2Choice == "Spock")
                {
                    Console.WriteLine("Paper disproves Spock");
                    PlayerWin(p1,p2);
                }
            }

            //if choice is scissors, scissors beats paper and lizard, scissors loses to rock and spock
            else if (p1Choice == "Scissors")
            {
                if (p2Choice == "Rock")
                {
                    Console.WriteLine("Rock crushes Scissors!");
                    PlayerWin(p2,p1);
                }
                else if (p2Choice == "Paper")
                {
                    Console.WriteLine("Scissors cuts Paper!");
                    PlayerWin(p1,p2);
                }
                else if (p2Choice == "Lizard")
                {
                    Console.WriteLine("Scissors decapitates Lizard!");
                    PlayerWin(p1,p2);
                }
                else if (p2Choice == "Spock")
                {
                    Console.WriteLine("Spock smashes Scissors!");
                    PlayerWin(p2,p1);
                }
            }

            //if choice is lizard, lizard beats paper and spock, lizard loses to rock and scissors
            else if (p1Choice == "Lizard")
            {
                if (p2Choice == "Rock")
                {
                    Console.WriteLine("Rock smashes Lizard!");
                    PlayerWin(p2,p1);
                }
                else if (p2Choice == "Paper")
                {
                    Console.WriteLine("Lizard eats Paper!");
                    PlayerWin(p1,p2);
                }
                else if (p2Choice == "Scissors")
                {
                    Console.WriteLine("Scissors decapitates Lizard!");
                    PlayerWin(p2,p1);
                }
                else if (p2Choice == "Spock")
                {
                    Console.WriteLine("Lizard poisons Spock!");
                    PlayerWin(p1,p2);
                }
            }

            //if choice is spock, spock beats rock and scissors, spock loses to lizard and paper
            else if (p1Choice == "Spock")
            {
                if (p2Choice == "Rock")
                {
                    Console.WriteLine("Spock vaporizes Rock!");
                    PlayerWin(p1,p2);
                }
                else if (p2Choice == "Paper")
                {
                    Console.WriteLine("Paper disproves Spock!");
                    PlayerWin(p2,p1);
                }
                else if (p2Choice == "Lizard")
                {
                    Console.WriteLine("Lizard poisons Spock!");
                    PlayerWin(p2,p1);
                }
                else if (p2Choice == "Scissors")
                {
                    Console.WriteLine("Spock smashes Scissors!");
                    PlayerWin(p1,p2);
                }
            }
        }

        public void DisplayWinner(int wins, int roundsToWin)
        {
            if (wins == roundsToWin)
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

        public bool AskToPlayAgain()
        {
            Console.WriteLine("Would you like to play again? [Y] or [N]");
            string playAgainChoice = Console.ReadLine().ToLower();

            while (playAgainChoice != "y" && playAgainChoice != "n")
            {
                Console.WriteLine("Please choose [Y] or [N]");
                playAgainChoice = Console.ReadLine();
            }

            if (playAgainChoice == "y")
            {
                p1.wins = 0;
                p2.wins = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SingleRound(int roundsToWin)
        {
            while (!(p1.wins == roundsToWin) && !(p2.wins == roundsToWin))
            {
                string p1Choice = p1.ChooseGesture();
                Console.Clear();
                string p2Choice = p2.ChooseGesture();
                Console.Clear();

                Console.WriteLine($"{p1.name} chose: {p1Choice}\n{p2.name} chose: {p2Choice}");
                Console.WriteLine();

                DetermineRoundWinner(p1Choice, p2Choice);

                Console.WriteLine($"{p1.name} {p1.wins} - {p2.wins} {p2.name}");
                Console.WriteLine();
            }
        }

        public void PlayGame()
        {
            DisplayRules();
            ChooseGameType();

            bool playGame = false;
            do
            {
                int gameRounds = ChooseGameRounds();
                int roundsToWin = (gameRounds / 2) + 1;
                Console.Clear();

                SingleRound(roundsToWin);

                DisplayWinner(p1.wins, roundsToWin);

                playGame = AskToPlayAgain();

            } while (playGame == true);
        }
    }
}
