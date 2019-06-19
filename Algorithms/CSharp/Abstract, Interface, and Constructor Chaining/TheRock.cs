using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CSharp.Abstract__Interface__and_Constructor_Chaining
{
    // The Rock is a wrestler who gets paid and has music. 
    // The Rock may or may not know different forms of martial arts
    // If he does know the form of martial arts, he should have a blueprint of all moves in that form.
    public class TheRock : Wrestler, IBoxing, IMuayThai
    {
        string _title;
        string _announcement;

        // if given nothing, give these defaults and pass to the other constructor
        // could use "base" instead of "this" to pass to base class
        public TheRock() : this("The Best and Greatest", "Welcome with a round of applause!")
        {

        }

        public TheRock(string title, string announcement)
        {
            _title = title;
            _announcement = announcement; 
        }

        new public static int Bonus = 10000; // new keyword to override and give 2x bonus

        public override int GetTotalPay(int hours)
        {
            return CalculateTotalPay(hours);
        }
        private int CalculateTotalPay(int hours)
        {
            int total = Bonus + PaymentPerHour(hours);
            Console.WriteLine(total);
            return total;
        }

        public override void FinishingMove()
        {
            Console.WriteLine("Finishing move is avalanche.");
        }

        public override void ThemeMusic()
        {
            Console.WriteLine("Intro music is Moana You're Welcome.");
        }

        public void JumpOutOfHelicopter()
        {
            Console.WriteLine("JUMP!");
        }

        public void SokKlap()
        {
            Console.WriteLine("Spinning elbow strike.");
        }

        public void KhaoYao()
        {
            Console.WriteLine("Knee bomb.");
        }

        public void AddGlove(string whichHand)
        {
            Console.WriteLine("Put on glove.");
        }

        public void RemoveGlove(string whichHand)
        {
            Console.WriteLine("Take off glove.");
        }

        public void Hook()
        {
            Console.WriteLine("Hit.");
        }

        public void Cross()
        {
            Console.WriteLine("Hit.");
        }

        public void Jab()
        {
            Console.WriteLine("Hit.");
        }

        public void UpperCut()
        {
            Console.WriteLine("Hit.");
        }
    }
}
