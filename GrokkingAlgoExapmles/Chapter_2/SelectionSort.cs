using System;
using System.Collections.Generic;
using System.Text;

namespace GrokkingAlgoExapmles.Chapter_2
{
    /// <summary>
    /// The selection sort. O(n) of O(n) = O(n^2)
    /// </summary>
    public class SelectionSort
    {
        /// <summary>
        /// Sorts an array Ascending or Descending -*In Place*-
        /// </summary>
        /// <param name="toSortArray">The to sort array.</param>
        /// <param name="Asc">If true, Ascending.</param>
        /// <returns> The array Sorted ASC/DESC .</returns>
        public static int[] SortArray (int[] toSortArray, bool Asc = true)
        {
            for (int i = 0; i < toSortArray.Length; i++)
            {
                int cindex;
                if (Asc)
                    cindex = FindSmallestIndexFromXToArrayLength(toSortArray, i);
                else
                    cindex = FindMaxIndexFromXToArrayLength(toSortArray, i);

                int temp = toSortArray[cindex];
                toSortArray[cindex] = toSortArray[i];
                toSortArray[i] = temp;
            }
            return toSortArray;
        }

        /// <summary>
        /// Finds the smallest index from x to array length.
        /// </summary>
        /// <param name="toSortArray">The to sort array.</param>
        /// <param name="i">The i.</param>
        private static int FindSmallestIndexFromXToArrayLength (int[] toSortArray, int i)
        {
            int minIDX = i;
            for (int j = i + 1; j < toSortArray.Length; j++)
                if (toSortArray[j] < toSortArray[minIDX])
                    minIDX = j;
            return minIDX;
        }

        /// <summary>
        /// Finds the smallest index from x to array length.
        /// </summary>
        /// <param name="toSortArray">The to sort array.</param>
        /// <param name="i">The i.</param>
        private static int FindMaxIndexFromXToArrayLength (int[] toSortArray, int i)
        {
            int maxIDX = i;
            for (int j = i + 1; j < toSortArray.Length; j++)
                if (toSortArray[j] > toSortArray[maxIDX])
                    maxIDX = j;
            return maxIDX;
        }


    }
}
