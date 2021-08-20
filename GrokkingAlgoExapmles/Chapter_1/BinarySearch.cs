using System;
using System.Collections.Generic;
using System.Text;

namespace GrokkingAlgoExapmles.Chapter_1
{
    /// <summary>
    /// The binary search.Big O(log n)
    /// </summary>
    public class BinarySearch
    {
        /// <summary>
        /// search in an sorted array using the binary search algorithm -- loop 
        /// </summary>
        /// <param name="searchIn">array to search in </param>
        /// <param name="searchFor">element to search for </param>
        /// <returns> (-1) if not found or the index of element if found </returns>
        public static int BSearch (int[] searchIn , int searchFor , out int trialsCount) {
            trialsCount = 0;
            int lowPos = 0;
            int highPos = searchIn.Length-1;
            while (lowPos<=highPos)
            {
                trialsCount++;
                int midPos = (lowPos + highPos) / 2;
                if (searchIn[midPos] == searchFor)
                    return midPos;
                else if (searchIn[midPos] > searchFor)
                    highPos = midPos - 1;
                else
                    lowPos = midPos + 1;
            }
            return -1;
        }
    }
}
