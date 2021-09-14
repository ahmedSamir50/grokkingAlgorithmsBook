using System;
using System.Collections.Generic;
using System.Text;

namespace GrokkingAlgoExapmles.Chapter_2
{
    /// <summary>
    /// The selection sort.  O(n) = O(n^2)
    /// </summary>
    public class SelectionSort<T> : ComparingTBase<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts an array Ascending or Descending -*In Place*-
        /// loop throw array each time find the smallest / the biggest elemet
        /// set it at the start and then go to the next smallest / biggest element 
        /// until array is sorted 
        /// </summary>
        /// <param name="toSortArray">The to sort array.</param>
        /// <param name="Asc">If true, Ascending.</param>
        /// <returns> The array Sorted ASC/DESC .</returns>
        public static T[] SortArray (T[] toSortArray, bool Asc = true)
        {
            for (int i = 0; i < toSortArray.Length; i++)
            {
                int cindex;
                if (Asc)
                    cindex = FindSmallestIndexFromXToArrayLength(toSortArray, i);
                else
                    cindex = FindMaxIndexFromXToArrayLength(toSortArray, i);

                T temp = toSortArray[cindex];
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
        private static int FindSmallestIndexFromXToArrayLength (T[] toSortArray, int i)
        {
            int minIDX = i;
            for (int j = i + 1; j < toSortArray.Length; j++)
                if (IsLessThan( toSortArray[j],  toSortArray[minIDX]))
                    minIDX = j;
            return minIDX;
        }

        /// <summary>
        /// Finds the smallest index from x to array length.
        /// </summary>
        /// <param name="toSortArray">The to sort array.</param>
        /// <param name="i">The i.</param>
        private static int FindMaxIndexFromXToArrayLength (T[] toSortArray, int i)
        {
            int maxIDX = i;
            for (int j = i + 1; j < toSortArray.Length; j++)
                if (IsBiggerThan( toSortArray[j] , toSortArray[maxIDX]))
                    maxIDX = j;
            return maxIDX;
        }


    }
}
