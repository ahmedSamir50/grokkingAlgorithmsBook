using GrokkingAlgoExapmles;
using NUnit.Framework;
using System;
using System.Linq;

namespace GrokkingAlgoTests.ChapterTwoTest
{
    public class QuickSortTests
    {
        [Test]
        public void RandArraySortedASC ()
        {
            int[] array = { 5, 6, 9, 10, 3, 7, 2, 1, 8, 0, 4, 100, -100 };
            array= QuickSort<int>.QSort(array);
            Printarray(array);
            Assert.IsTrue(array.SequenceEqual(new int[] { -100, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100 }));
            // Char 
            char[] charArray = { 'A', 'B', 'Z', 'N', 'M', 'a', 'C' };
            charArray = QuickSort<char>.QSort(charArray);
            Printarray(charArray);
            Assert.IsTrue(charArray.SequenceEqual(new char[] { 'A', 'B', 'C', 'M', 'N', 'Z', 'a' }));
        }

        [Test]
        public void RandArraySortedASC2()
        {
            int[] array = Enumerable.Range(1, 1000).ToArray();
            int[] arrayRev = QuickSort<int>.QSort(array, true);
            Printarray(array);
            Assert.IsTrue(arrayRev.SequenceEqual(array.Reverse()));
        }

        [Test]
        public void RandArraySortedDESC ()
        {
            int[] array = { 5, 6, 9, 10, 3, 7, 2, 1, 8, 0, 4, 100, -100 };
            array = QuickSort<int>.QSort(array,true);
            Assert.IsTrue(array.SequenceEqual(new int[] { 100, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, -100 }));
            // Char 
            char[] charArray = { 'A', 'B', 'Z', 'N', 'M', 'a', 'C' };
            charArray = QuickSort<char>.QSort(charArray, true);
            Printarray(charArray);
            Assert.IsTrue(charArray.SequenceEqual(new char[] {  'a', 'Z', 'N', 'M', 'C', 'B', 'A' }));
        }

        private static void Printarray<T> (T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
        }
    }

}
