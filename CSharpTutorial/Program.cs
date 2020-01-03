using System;
using System.Collections.Generic;

namespace CSharpTutorial
{
    class Program
    {
        // Scenario: Create a Console app that takes in 2 numbers and allows you to 
        // add/sub/mult/divide them and prints the result
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            string input1 = Console.ReadLine();
            decimal firstNum = decimal.Parse(input1);

            Console.WriteLine("Enter your second number");
            string input2 = Console.ReadLine();
            decimal secondNum = decimal.Parse(input2);

            Console.WriteLine("Enter your operation: +, -, *, or /");
            string operation = Console.ReadLine();

            decimal result = 0;

            Calculator calc = new Calculator();
            
            switch (operation)
            {
                case "+":
                    result = calc.Add(firstNum, secondNum);
                    break;
                case "-":
                    result = calc.Subtract(firstNum, secondNum);
                    break;
                case "*":
                    result = calc.Multiply(firstNum, secondNum);
                    break;
                case "/":
                    result = calc.Divide(firstNum, secondNum);
                    break;
                default:
                    Console.WriteLine("Sorry this wasn't a correct choice.");
                    break;
            }

            Console.WriteLine($"The solution {firstNum} {operation} {secondNum} = {result}");
            Console.Read();
        }
    }
}
