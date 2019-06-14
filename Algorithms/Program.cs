using Algorithms.Algorithms;
using Algorithms.CSharp;
using Algorithms.LinkedList;
using Algorithms.Stack;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //var first = new Node(1);
            //var second = new Node(2);
            //var llist = new LinkedList2(first);
            //llist.AddLast(second);

            //ReverseLinkedList test = new ReverseLinkedList();
            //test.Run(first);

            Elevator elevator = new Elevator();
            elevator.CallElevator(1, true);
        }
    }
}
