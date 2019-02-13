using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Data_Structures.Hash_Tables
{
    public class HashTable
    {
        const double _fillFactor = 0.75;

        int _maxItemsAtCurrentSize;

        int _count;

        HashTableArray<TKey, TValue> _array;

        public HashTable()
            : this(1000)
        {

        }
    }
}
