using System;
using System.Collections.Generic;
using System.Text;

namespace GrokkingAlgoExapmles.Chapter_1
{
    /// <summary>
    /// The binary search.Big O(log n)
    /// </summary>
    public class BinarySearch<T> : ComparingTBase<T> where T : IComparable<T>
    {
      
        public static int BSearch (T[] searchIn, T searchFor, out int trialsCount)
        {
            trialsCount = 0;
            int lowPos = 0;
            int highPos = searchIn.Length - 1;
            while (lowPos <= highPos)
            {
                trialsCount++;
                int midPos = (lowPos + highPos) / 2;
                if (searchIn[midPos].Equals( searchFor))
                    return midPos;
                else if (IsBiggerThan(searchIn[midPos], searchFor))
                    highPos = midPos - 1;
                else
                    lowPos = midPos + 1;
            }
            return -1;
        }
    }
}
