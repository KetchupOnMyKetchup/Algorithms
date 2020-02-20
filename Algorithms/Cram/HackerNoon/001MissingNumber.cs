using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram
{
    /// <summary>
    /// How do you find the missing number in a given integer array of 1 to 100?
    /// </summary>
    public class _001MissingNumber
    {
        public int FindMissingNumber(int[] array)
        {
            // for loop and check against hardcoded array with all numbers (brute force)

            // figure out difference between each and the one that is 2 is where its gone wrong

            // add up the sum and find out what is missing by subtracting from expected sum
            // how to find expected sum
            // how to get sum array, for loop.. is there better?

            double expectedSum = 0;
            int expectedLength = array.Length + 1;

            expectedSum = (expectedLength / 2.0) * (1 + expectedLength);

            //int expectedSum = totalCount * ((totalCount + 1) / 2);

            int sumArray = 0;
            foreach (var item in array)
            {
                sumArray += item;
            }

            return (int)expectedSum - sumArray;

            // Time should be n + 1
        }
    }
}
