using System;
using System.Collections.Generic;
using System.Text;

namespace GrokkingAlgoExapmles.Chapter_1
{
    /// <summary>
    /// The simple search.  Big O(n)
    /// </summary>
    public class SimpleSearch
    {
        /// <summary>
        /// Linear the search. With O(n)
        /// no difference if the array is sorted or not 
        /// </summary>
        /// <param name="searchIn">The search in. array </param>
        /// <param name="searchFor">The search for. number/ element</param>
        /// <param name="trialsCount">The trials count. till finish</param>
        /// <returns>An int. (-1) if not found or the element index if found </returns>
        public static int LineSearch (int[] searchIn, int searchFor, out int trialsCount) {
            trialsCount = 1;
            for (int i = 0; i < searchIn.Length; i++,trialsCount++)
            {
                if (searchIn[i] == searchFor)
                    return i;
            }
            return -1;
        }
    }
}
