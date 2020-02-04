using System;
using System.Collections.Generic;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Project 1: Intro and Fizz Buzz Problem
            FizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.Run();

            // Project 2: Simple Calculator to Add, Subtract, Divide, Multiply 2 numbers
            Calculator calc = new Calculator();
            calc.Run();

            // Project 3: Rock Paper Scissors Game
            RockPaperScissors rockPaperScissors = new RockPaperScissors();
            rockPaperScissors.Run();

            // Project 4: Tic Tac Toe (TTT) Game
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.Run();

            // Work on HW 1, see solution class if needed
            // Work on HW 2, see solution class if needed

            // Project 5: Simple Blackjack, no classes and Ace = 1 only
            BlackJackSimple blackJackSimple = new BlackJackSimple();
            blackJackSimple.Run();

            // Project 6: Refactor Project 4 Tic Tac Toe
            // See how a method was created to avoid replicating work. 
            // Lines with refactor are marked with comments.
            TicTacToeRefactor tttRefactor = new TicTacToeRefactor();
            tttRefactor.Run();

            // Project 7: Intro to Collections with Bags of Marbles
            Marbles marbles = new Marbles();
            marbles.Run();


            // Project 8: Fizz Buzz Variant Problem


            // Work on HW 3, see solution class if needed

        }
    }
}
