using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.CSharp.LL;

namespace AlgorithmsTests.CSharp
{
    [TestClass]
    public class LinkedList2Tests
    {
        LinkedList1<int> ll = new LinkedList1<int>();

        [TestInitialize]
        public void TestInitialize()
        {
            ll.AddFirst(5);
            ll.AddFirst(4);
            ll.AddFirst(3);
            ll.AddFirst(2);
            ll.AddFirst(1);
            ll.AddLast(6);
        }

        [TestMethod]
        public void LinkedListTest()
        {
            ll.Reverse();

        }
    }
}
