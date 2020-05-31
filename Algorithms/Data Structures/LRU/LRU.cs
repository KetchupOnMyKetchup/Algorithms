using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Data_Structures.LRU
{
    /// <summary>
    /// Using built in .NET LinkedListNode 
    /// Adding every key/value (int/LinkedListNode<int>) to the Dictionary (which gives fast lookup) (cache) and every int value to the LinkedList (this gives ORDER/Re-order)
    /// Dict has no way to order. LL has slow lookups.
    /// </summary>
    class LRUCache
    {
        LinkedList<DLinkedNode> ll = new LinkedList<DLinkedNode>();
        Dictionary<int, LinkedListNode<DLinkedNode>> cache = new Dictionary<int, LinkedListNode<DLinkedNode>>();
        int _capacity;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        class DLinkedNode
        {
            public int Key;
            public int Value;
        }

        public int Get(int key)
        {
            if (!cache.ContainsKey(key)) return -1;

            LinkedListNode<DLinkedNode> node = cache[key];

            // move to head
            ll.Remove(node);
            ll.AddFirst(node);

            return node.Value.Value;
        }

        public void Put(int key, int value)
        {
            // If key is found, update it
            if (!cache.ContainsKey(key))
            { 
                LinkedListNode<DLinkedNode> foundNode = cache[key];
                foundNode.Value = new DLinkedNode { Key = key, Value = value };

                // move to head
                ll.Remove(foundNode);
                ll.AddFirst(foundNode);
            }
            else // otherwise add a new entry
            {
                LinkedListNode<DLinkedNode> newNode = new LinkedListNode<DLinkedNode>(new DLinkedNode {Key = key, Value = value }); // add key into construction
                cache.Add(key, newNode);

                // add to head
                ll.AddFirst(newNode);

                if (ll.Count > _capacity) PopTail();
            }
        }

        private void PopTail()
        {
            // find out what is at end of LL
            var last = ll.Last;

            // remove from cache Dict
            cache.Remove(last.Value.Key);

            ll.RemoveLast();
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
