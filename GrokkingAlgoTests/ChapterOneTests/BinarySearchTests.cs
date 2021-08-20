using GrokkingAlgoExapmles.Chapter_1;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Linq;


namespace GrokkingAlgoTests.ChapterOneTests
{
    /// <summary>
    /// The binary search tests. for found , not found results and maximum trails as Big O Notation representation -worst case -
    /// </summary>
    public class BinarySearchTests
    {
        /// <summary>
        /// Sorted  array existing element returns the element index.
        /// </summary>
        [Test]
        public void SortedArrayExistingElementReturnsTheElementIndex () {
            var result = BinarySearch<int>.BSearch(new int[] {1,2,3,4,5,6,7,8,9,10 } , 10 , out int actualTrials);
            Console.WriteLine(actualTrials);
            int _MaxTraialsShouldBe = (int)Math.Log2(10) + 1;
            Assert.AreEqual(9,result);
            Assert.IsTrue(_MaxTraialsShouldBe >= actualTrials);
        }
        /// <summary>
        /// Sorted  array existing element returns the element index.
        /// </summary>
        [Test]
        public void SortedArrayExistingElementReturnsTheElementIndex2 ()
        {
            const int elementsCountInArray = 10000000;
            var arr = Enumerable.Range(10, elementsCountInArray).ToArray(); ;

            var result = BinarySearch<int>.BSearch(arr, 10000009 , out int actualTrials);
            int _MaxTraialsShouldBe = (int) Math.Log2(elementsCountInArray) + 1;
           
            Assert.AreEqual(9999999,result);
            Assert.IsTrue(_MaxTraialsShouldBe >= actualTrials);
        }
        /// <summary>
        /// Trials the count in worst case is log array count plus one if found or less.
        /// </summary>
        [Test]
        public void TrialsCountInWorstCaseIsLogArrayCountPlusOneIfFoundOrLess () {
            const int elementsCountInArray = 10000000;
            var arr = Enumerable.Range(10, elementsCountInArray).ToArray(); ;

            var result = BinarySearch<int>.BSearch(arr, 10000009, out int actualTrials);
            int _MaxTraialsShouldBe = (int)Math.Log2(elementsCountInArray) + 1;

            Assert.AreEqual(9999999, result);
            Assert.IsTrue(_MaxTraialsShouldBe>= actualTrials);
        }

        /// <summary>
        /// Trials the count in worst case is log array count plus one if not found or less and returns minus one.
        /// </summary>
        [Test]
        public void TrialsCountInWorstCaseIsLogArrayCountPlusOneIfNotFoundOrLessAndReturnsMinusOne ()
        {
            const int elementsCountInArray = 10000000;
            var arr = Enumerable.Range(10, elementsCountInArray).ToArray(); ;

            var result = BinarySearch<int>.BSearch(arr, 5, out int actualTrials);
            int _MaxTraialsShouldBe = (int)Math.Log2(elementsCountInArray) + 1;

            Assert.AreEqual(-1, result);
            Assert.IsTrue(_MaxTraialsShouldBe >= actualTrials);
        }
    }
}
