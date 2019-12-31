using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int intTemp = Convert.ToInt32(Console.ReadLine());

            Add(int.Parse(input), 2);
            Console.WriteLine("Hello World!");
        }

        public static int Add(int num1, int num2)
        {
            return 1;
        }
    }
}
