using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CSharp
{
    /// <summary>
    /// https://www.akadia.com/services/dotnet_delegates_and_events.html
    /// </summary>
    class Delegates
    {
        // Declaration
        public delegate void SimpleDelegate();

        class TestDelegate
        {
            public static void MyFunc()
            {
                Console.WriteLine("I was called by delegate ...");
            }

            //public static void Main()
            //{
            //    // Instantiation
            //    SimpleDelegate simpleDelegate = new SimpleDelegate(MyFunc);

            //    // Invocation
            //    simpleDelegate();
            //}
        }
    }
}
