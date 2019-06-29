using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CSharp.Abstract__Interface__and_Constructor_Chaining
{
    /// <summary>
    /// Abstract class is nothing special to look at when you want to differentiate with a regular class. 
    /// But it has got some methods which are unimplemented, or only declared, not defined. 
    /// In that case, all those methods and the class itself are renamed with the “abstract” keyword.
    /// Abstract classes cannot be instantiated.
    /// The classes which Inherit/Extend this abstract class, have to implement/define all the abstract methods of the parent abstract class.
    /// </summary>
    public abstract class Wrestler
    {
        public static int Bonus = 5000;

        public int PaymentPerHour(int hours)
        {
            return hours * 250;
        }

        //•	Virtual methods have an implementation and provide the derived classes with the option of overriding it. 
        public virtual int GetTotalPay(int hours)
        {
            return CalculateTotalPay(hours);
        }

        // Can override with new keyword in inherited class, doesn't need to be virtual
        public int GetTotalPay2(int hours)
        {
            return CalculateTotalPay(hours);
        }

        // Abstract methods do not provide an implementation and force the derived classes to override the method. 
        // So, abstract methods have no actual code in them, and subclasses HAVE TO override the method.
        public abstract void ThemeMusic();

        public abstract void FinishingMove();

        // Cannot be abstract, so cannot be overriden
        private int CalculateTotalPay(int hours)
        {
            int total = Bonus + PaymentPerHour(hours);
            Console.WriteLine($"The wrestler will make ${total}.");
            return total;
        }
    }
}
