using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Basics_Part1
{
    class _03IntroCollections
    {
        //static void Main()
        //{
        //    // Tell user we can get bags for marbles, ask how many bags they want to get
        //    Console.WriteLine("We can get bags of marbles. How many bags would you like?");
        //    var stringNum = Console.ReadLine();
        //    int numBags = int.Parse(stringNum);
        //    var bags = SetNumberBags(numBags);
        //    Console.WriteLine($"You chose {numBags} bags.");

        //    // WHile loop
        //    bool keepLooping = true;
        //    while (keepLooping == true)
        //    {
        //        // Give user bag options
        //        Console.WriteLine("Which bag do you want to fill with marbles?");
        //        // Ask user which bag they want to fill
        //        Console.WriteLine($"Pick a bag # between 1 and {bags.Count}");
        //        int bagNum = int.Parse(Console.ReadLine());

        //        // Ask user how many marbles to put in bag
        //        Console.WriteLine("How many marbles would you like to put in it?");
        //        int numMarbles = int.Parse(Console.ReadLine());

        //        // get right bag
        //        FillBag(bags[bagNum - 1], numMarbles);

        //        // Ask user if they want to continue
        //        Console.WriteLine("Do you want to continue? (Y/N)");
        //        if (Console.ReadLine().ToUpper() != "Y") keepLooping = false;
        //        Console.WriteLine("---------------------------------------");
        //    }

        //    // Tell user how many marbles are in each bag + what colors are in bag
        //    int count = 0;

        //    foreach (var bag in bags)
        //    {
        //        Console.WriteLine($"Bag {count + 1} has {bag.Count} marbles in it. The contents of this bag are:");

        //        foreach (string marble in bag)
        //        {
        //            Console.WriteLine(marble);
        //        }

        //        count++;
        //    }
        //}

        public static void FillBag(List<string> bag, int numberOfMarblesToFillBag)
        {
            string[] colors = new string[] { "red", "orange", "yellow", "green", "blue", "purple" };

            Random rand = new Random();

            for (int i = 0; i < numberOfMarblesToFillBag; i++)
            {
                int randomNum = rand.Next(0, 6);
                string color = colors[randomNum];
                bag.Add(color);
                Console.WriteLine($"Marble {i + 1} is {color}.");
            }

            Console.WriteLine("The bag has been randomly filled with marbles!");
        }

        public static List<List<string>> SetNumberBags(int num)
        {
            List<List<string>> bags = new List<List<string>>();

            for (int i = 0; i < num; i++)
            {
                List<string> bag = new List<string>();
                bags.Add(bag);
            }

            Console.WriteLine($"You have {num} bag(s) for marbles. They are all empty.");

            return bags;
        }
    }
}
