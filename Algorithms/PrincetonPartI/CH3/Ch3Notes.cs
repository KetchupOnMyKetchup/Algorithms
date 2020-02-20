using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.PrincetonPartI.CH3
{
    /// <summary>
    /// Upper bound = worst case = O notation
    /// Lower bound = best possible time
    /// When upper bound = lower bound, you have an optimal awesome algorithm for time
    /// Not related to space usage being good or bad, however.
    /// Make sure to consider both time- and space- optimization. 
    /// 
    /// Mergesort is optimal with # compares (N log N for both upper and lower bound).
    /// Mergesort is NOT optimal with respect to space usage.
    /// 
    /// Stability: If you sort by 1 column, then sort by a 2nd.. stability is if it preserves both sorts. 
    /// 
    /// Insertion sort and Mergesort and stable. They never move equal items past each other, so preserve first set of sorted columns. 
    /// Selection sort and Shellsort are not. Long distance exchanges moving keys past other keys that could be equal. 
    /// 
    /// Primitives can be sorted by their type.. so make a class just for int sort for example.
    /// Why? This is faster if performance is the most important and reusability isn't a big deal. 
    /// </summary>
    class Ch3Notes
    {
        
    }
}
