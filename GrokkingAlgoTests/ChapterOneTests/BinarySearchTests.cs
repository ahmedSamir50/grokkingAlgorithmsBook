using GrokkingAlgoExapmles.Chapter_1;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Linq;


namespace GrokkingAlgoTests.ChapterOneTests
{
    public class BinarySearchTests
    {

        [SetUp]
        public  void SetUp () { 
        }

        [Test]
        public void SortedArrayExistingElementReturnsTheElementIndex () {
            var result = BinarySearch.BSearch(new int[] {1,2,3,4,5,6,7,8,9,10 } , 10 , out int actualTrials);
            Console.WriteLine(actualTrials);
            int _MaxTraialsShouldBe = (int)Math.Log2(10) + 1;
            Assert.AreEqual(9,result);
            Assert.IsTrue(_MaxTraialsShouldBe >= actualTrials);
        }
        [Test]
        public void SortedArrayExistingElementReturnsTheElementIndex2 ()
        {
            const int elementsCountInArray = 10000000;
            var arr = Enumerable.Range(10, elementsCountInArray).ToArray(); ;

            var result = BinarySearch.BSearch(arr, 10000009 , out int actualTrials);
            int _MaxTraialsShouldBe = (int) Math.Log2(elementsCountInArray) + 1;
           
            Assert.AreEqual(9999999,result);
            Assert.IsTrue(_MaxTraialsShouldBe >= actualTrials);
        }
        [Test]
        public void TrialsCountInWortstCaseIsLogArrayCountPlusOneIfFoundOrLess () {
            const int elementsCountInArray = 10000000;
            var arr = Enumerable.Range(10, elementsCountInArray).ToArray(); ;

            var result = BinarySearch.BSearch(arr, 10000009, out int actualTrials);
            int _MaxTraialsShouldBe = (int)Math.Log2(elementsCountInArray) + 1;

            Assert.AreEqual(9999999, result);
            Assert.IsTrue(_MaxTraialsShouldBe>= actualTrials);
        }

        [Test]
        public void TrialsCountInWortstCaseIsLogArrayCountPlusOneIfNotFoundOrLessAndReturnsMinusOne ()
        {
            const int elementsCountInArray = 10000000;
            var arr = Enumerable.Range(10, elementsCountInArray).ToArray(); ;

            var result = BinarySearch.BSearch(arr, 5, out int actualTrials);
            int _MaxTraialsShouldBe = (int)Math.Log2(elementsCountInArray) + 1;

            Assert.AreEqual(-1, result);
            Assert.IsTrue(_MaxTraialsShouldBe >= actualTrials);
        }
    }
}
