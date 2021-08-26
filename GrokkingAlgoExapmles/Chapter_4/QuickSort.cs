using System;
using System.Collections.Generic;
using System.Linq;

namespace GrokkingAlgoExapmles
{
    public class QuickSort<T> : ComparingTBase<T> where T : IComparable<T>
    {
        public static T[] QSort(T[] array, bool DESC = false)
        {
            if (array.Length < 2)
                return array;

            T pivotElem = array[0];

            //int[] lessArr = array.Where(a => a < pivotElem).ToArray();
            //int[] greaterArray = array.Where(a => a > pivotElem).ToArray();
            List<T> less = new List<T>();
            List<T> big = new List<T>();
            for (int i = 1; i < array.Length; i++)
            {
                if (IsBiggerThan(array[i], pivotElem))
                    big.Add(array[i]);
                else
                    less.Add(array[i]);
            }
            Console.WriteLine("*Traial*");
            return ASCORDESCDecidion(DESC, pivotElem, less, big);

        }
        static T[] ASCORDESCDecidion(bool DESC, T pivotElem, List<T> less, List<T> big)
        {
            return !DESC ?
                            QSort(less.ToArray()).Concat(new T[] { pivotElem }).Concat(QSort(big.ToArray()))
                            .ToArray()
                            :
                             QSort(big.ToArray(),true).Concat(new T[] { pivotElem }).Concat(QSort(less.ToArray(),true))
                            .ToArray();
        }

    }
}
