using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_rock_papergame
{
    class Game
    {
        string playerOne;
        string computer;
        int getScore;
        
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to RPSLS Game. Here are the rules. Scissors cuts Paper. Paper covers Rock. Rock crushes Lizard. \n");
            Console.WriteLine("Lizard poisons Spock. Spock smashes Scissors. Scissors decapitates Lizard. Lizard eats Paper. \n");
            Console.WriteLine("Paper disproves Spock. Spock vaporizes Rock.");
            Console.WriteLine("We have 2 methods to play. You vs. computer or 2 human players. Please choose one.");
            Console.ReadLine();
            Console.ReadKey();
        }
        public void StartGame()
        {
            Console.WriteLine("Choose your weapon; rock, paper, scissors, spock, lizard.");
            Console.ReadLine();
            playerOne = Console.ReadLine();

            Random RandomNumber = new Random();
            int x = RandomNumber.Next(0, 5);

            if (x == 0)
            {
                getScore = "rock";
            }
            if (x == 1)
            {
                getScore = "scissors";
            }
            if (x == 2)
            {
                getScore = "paper";
            }
            if (x == 3)
            {
                getScore = "spock";
            }
            if (x == 4)
            {
                getScore = "lizard";
            }
            results();
        }

        while(index <= 3, playerOne, computer)
            Console.WriteLine(" You Won {0}."); 
    }
    }
}
