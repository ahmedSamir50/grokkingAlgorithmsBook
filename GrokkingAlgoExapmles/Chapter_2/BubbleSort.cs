using System;
using System.Collections.Generic;
using System.Text;

namespace GrokkingAlgoExapmles.Chapter_2
{
    public class BubbleSort<T> : ComparingTBase<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts an array Ascending or Descending -*In Place*-
        /// </summary>
        /// <param name="toSortArray">The to sort array.</param>
        /// <param name="Asc">If true, Ascending.</param>
        /// <returns> The array Sorted ASC/DESC .</returns>
        public static T[] SortArray(T[] toSortArray, bool Asc = true)
        {
            for (int i = 0; i < toSortArray.Length - 1; i++)
            {
                for (int j = 0; j < toSortArray.Length - i - 1; j++)
                {
                    if (Asc)
                    {
                        if (IsBiggerThan(toSortArray[j], toSortArray[j + 1]))
                        {
                            T temp = toSortArray[j];
                            toSortArray[j] = toSortArray[j + 1];
                            toSortArray[j + 1] = temp;
                        }
                    }
                    else
                    {
                        if (IsLessThan(toSortArray[j], toSortArray[j + 1]))
                        {
                            T temp = toSortArray[j];
                            toSortArray[j] = toSortArray[j + 1];
                            toSortArray[j + 1] = temp;
                        }
                    }
                }
            }
            return toSortArray;
        }
    }
}
