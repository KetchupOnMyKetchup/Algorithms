using Algorithms.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AlgorithmsTestProject
{
    [TestClass]
    public class LinkedListTests
    {
        private Node head;

        [TestInitialize()]
        public void Initialize()
        {
            Node node = new Node
            {
                data = 1
            };

            Node node2 = new Node
            {
                data = 2
            };

            node.next = node2;
            head = node;
        }

        [TestMethod]
        public void LinkedListTest()
        {
            LinkedList linkedList = new LinkedList(head);
            linkedList.AddFirst(3);

            var nodes = linkedList.ReturnAllNodes();
            Assert.AreEqual(3, nodes.Count);
            Assert.AreEqual(3, nodes[0].data);
            Assert.AreEqual(1, nodes[1].data);
            Assert.AreEqual(2, nodes[2].data);
        }
    }
}
