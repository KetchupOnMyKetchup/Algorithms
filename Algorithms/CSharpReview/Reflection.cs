using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CSharp
{
    class Reflection
    {
        void GetTypeExample()
        {
            int i = 42;
            System.Type type = i.GetType();
            System.Console.WriteLine(type); 
            // Output is: System.Int32
        }

        void GetAssemblyInfo()
        {
            // Using Reflection to get information of an Assembly:  
            System.Reflection.Assembly info = typeof(System.Int32).Assembly;
            System.Console.WriteLine(info);

            // Output is: mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        }
    }
}
