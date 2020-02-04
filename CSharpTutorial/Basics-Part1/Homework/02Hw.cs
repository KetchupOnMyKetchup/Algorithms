using System;
using System.Collections.Generic;
using System.Text;
using CSharpTutorial.Basics_Part1;

namespace CSharpTutorial.Homework
{
    class Hw2
    {
        
            // Problem 1:
            // Create 3 variables which are integers

            // create a new list of int

            // Using the Add() method, add the integers: 1, 2, and 3

            // Create a variable called count, and set its value to your list using the .Count() extension method.

            // Create a variable called first, and set its value to the first value in your list using the index.


            // Problem 2:
            // Write a string array with colors

            // Write a string array with types of pets

            // Using two foreach loops, generate every combination of pet color

            // Example output: black cat, white cat, orange cat, black bird, white bird, orange bird


            // Problem 3
            // Generate a List deck of cards using 2 string arrays

            // Randomly select a card out of your new deck

            // Find Numbers with Even Number of Digits
            public int FindNumbers(int[] nums)
            {
                return 0;
            }


            // Refactoring practice 1: 
            // See the below example. 
            //bool isPlayerOne = true;
            //    var arr = new char[9];
                
            //    // The if and else are repeated. How would you combine the logic into one method and call the method twice?
            //    if (isPlayerOne == true)
            //    {
            //        Console.WriteLine("Player one choose a number.");
            //        string input = Console.ReadLine();
            //        int numInput = int.Parse(input);
            //        arr[numInput - 1] = 'x';
            //        isPlayerOne = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Player two choose a number.");
            //        string input = Console.ReadLine();
            //        int numInput = int.Parse(input);
            //        arr[numInput - 1] = 'o';
            //        isPlayerOne = true;
            //    }
                // Do work here:



            // Refactoring practice 2: 
            // See the below example
                //Random rand = new Random();
                //var userScore = 0;
                //var compScore = 0;
                //var deck = BlackJack.GenerateDeck();

                //// These 3 methods are repeated, find a way to refactor this into one method
                //var userFaceDown = rand.Next(0, deck.Count);
                //Console.WriteLine($"User face down card is: {deck[userFaceDown]}");
                //userScore += BlackJack.AddCardValueToScore(deck[userFaceDown]);
                //deck.RemoveAt(userFaceDown);

                //var userFaceUp = rand.Next(0, deck.Count);
                //Console.WriteLine($"User face up card is: {deck[userFaceUp]}");
                //userScore += BlackJack.AddCardValueToScore(deck[userFaceDown]);
                //deck.RemoveAt(userFaceUp);

                //var compFaceUp = rand.Next(0, deck.Count);
                //Console.WriteLine($"Comp face up card is: {deck[compFaceUp]}");
                //compScore += BlackJack.AddCardValueToScore(deck[compFaceUp]);
                //deck.RemoveAt(compFaceUp);

                // Do work here:

    }
}
