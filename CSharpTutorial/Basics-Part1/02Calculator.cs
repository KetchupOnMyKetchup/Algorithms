using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    public class Calculator
    {
        public void Run()
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

        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
