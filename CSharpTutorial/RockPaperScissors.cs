using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    class RockPaperScissors
    {
        int userWins = 0;
        int compWins = 0;

        public void Run()
        {
            bool continueGame = true;

            Console.WriteLine("Welcome to RPS game");

            while (continueGame)
            {
                Console.WriteLine("Type number for your selection:\n1-->ROCK\n2-->PAPER\n3-->SCISSOR");
                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };

                Console.WriteLine("Enter your choice:");
                int user = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("You chose:" + choices[user]);

                Random rnd = new Random();
                int n = rnd.Next(0, 3);
                Console.WriteLine("Computer:" + choices[n]);

                FindWinner(user, n);
                
                Console.WriteLine("Do you want to continue(Y/N):");
                if (Console.ReadLine().ToUpper() != "Y") continueGame = false;
                Console.WriteLine("---------------------------------------");
            }

            Console.WriteLine("User wins " + userWins + " times");
            Console.WriteLine("Computer wins " + compWins + " times");
        }

        private void FindWinner(int user, int computer)
        {
            if (user == computer) Console.WriteLine("Draw! Same choices.");
            else if ((user == 1 && computer == 0) || (user == 0 && computer == 2) || (user == 2 && computer == 1))
            {
                Console.WriteLine("User wins");
                userWins += 1;
            }
            else
            {
                Console.WriteLine("Computer Wins");
                compWins += 1;
            }
        }
    }
}
