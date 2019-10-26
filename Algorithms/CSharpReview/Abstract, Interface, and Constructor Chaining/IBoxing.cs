using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CSharp.Abstract__Interface__and_Constructor_Chaining
{
    interface IBoxing
    {
        void AddGlove(string whichHand);
        void RemoveGlove(string whichHand);
        void Hook();
        void Cross();
        void Jab();
        void UpperCut();
    }
}
