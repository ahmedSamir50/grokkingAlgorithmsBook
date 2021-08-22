using GrokkingAlgoExapmles.Chapter_2;
using NUnit.Framework;
using System;
using System.Linq;

namespace GrokkingAlgoTests.ChapterTwoTest
{
    public class SelectionSortTests
    {
        [Test]
        public void RandArraySortedASC () {
            int[] array = {5,6,9,10,3,7,2,1,8,0,4,100,-100 };
            array = SelectionSort.SortArray(array);
            Printarray(array);
            // 012345678910
            Assert.IsTrue(array.SequenceEqual(new int[]{ -100,0,1,2,3,4,5,6,7,8,9,10,100 }));
        }

        [Test]
        public void RandArraySortedDESC ()
        {
            int[] array = { 5, 6, 9, 10, 3, 7, 2, 1, 8, 0, 4, 100, -100 };
            array = SelectionSort.SortArray(array , false);
            Printarray(array);
            Assert.IsTrue(array.SequenceEqual(new int[] { 100,10,9,8,7,6,5,4,3,2,1, 0, -100}));
        }

        private static void Printarray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+",");
            }
        }
    }
}
