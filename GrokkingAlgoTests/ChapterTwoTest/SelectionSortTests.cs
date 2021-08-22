using GrokkingAlgoExapmles.Chapter_2;
using NUnit.Framework;
using System;
using System.Linq;

namespace GrokkingAlgoTests.ChapterTwoTest
{
    public class SelectionSortTests
    {
        [Test]
        public void RandArraySortedASC ()
        {
            int[] array = { 5, 6, 9, 10, 3, 7, 2, 1, 8, 0, 4, 100, -100 };
            SelectionSort<int>.SortArray(array);
            Assert.IsTrue(array.SequenceEqual(new int[] { -100, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100 }));
            // Char 
            char[] charArray = { 'A', 'B', 'Z', 'N', 'M', 'a', 'C' };
            SelectionSort<char>.SortArray(charArray);
            Printarray(charArray);
            Assert.IsTrue(charArray.SequenceEqual(new char[] { 'A', 'B', 'C', 'M', 'N', 'Z', 'a' }));
        }

        [Test]
        public void RandArraySortedDESC ()
        {
            int[] array = { 5, 6, 9, 10, 3, 7, 2, 1, 8, 0, 4, 100, -100 };
            SelectionSort<int>.SortArray(array, false);
            Assert.IsTrue(array.SequenceEqual(new int[] { 100, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, -100 }));
            // Char 
            char[] charArray = { 'A', 'B', 'Z', 'N', 'M', 'a', 'C' };
            SelectionSort<char>.SortArray(charArray,false);
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
