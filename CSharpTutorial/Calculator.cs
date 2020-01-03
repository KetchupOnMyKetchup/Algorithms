using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    public class Calculator
    {
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
