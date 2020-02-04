using System;
using System.Collections.Generic;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Project 1
            Calculator calc = new Calculator();
            calc.Run();

            // Project 2
            RockPaperScissors rockPaperScissors = new RockPaperScissors();
            rockPaperScissors.Run();

            // Project 3
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.Run();

            // Work on HW 1
            // Work on HW 2

            // Project 4
            BlackJackSimple blackJackSimple = new BlackJackSimple();
            blackJackSimple.Run();

            // Project 5
            // See how a method was created to avoid replicating work. 
            // Lines with refactor are marked with comments.
            TicTacToeRefactor tttRefactor = new TicTacToeRefactor();
            tttRefactor.Run();

            // Project 6: Fizz Buzz Variant Problem


            // Work on HW 3

        }
    }
}
