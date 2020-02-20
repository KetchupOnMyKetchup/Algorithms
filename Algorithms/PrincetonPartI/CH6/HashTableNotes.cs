using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH6
{
    /// <summary>
    /// Hashing: Save items in a key-indexed table (hash the key to get the index)

    /// (HashMap allows null values as key and value whereas Hashtable doesn't allow nulls). 
    /// HashMap does not guarantee that the order of the map will remain constant over time. 
    /// HashMap is non synchronized whereas Hashtable is synchronized.
    /// 

    /// </summary>
    class HashTableNotes
    {
        //public int hashCode()
        //{
        //    int hash = 17;
        //    hash = 31 * hash + who.hashCode();
        //    hash = 31 * hash + when.hashCode();
        //    hash = 31 * hash + ((Double)amount).hashCode();
        //    return hash;
        //}

        //private int hash(Key key)
        //{ return (key.hashCode() & 0x7fffffff) % M; }
    }
}
