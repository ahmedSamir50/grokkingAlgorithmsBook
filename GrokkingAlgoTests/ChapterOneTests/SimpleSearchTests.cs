using GrokkingAlgoExapmles.Chapter_1;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Linq;


namespace GrokkingAlgoTests.ChapterOneTests
{
    public class SimpleSearchTests
    {

        [Test]
        public void ArrayExistingElementReturnsTheElementIndex () {
            int[] searchIn = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = SimpleSearch<int>.LineSearch(searchIn, 10 , out int actualTrials);
            Console.WriteLine(actualTrials);
            int _MaxTraialsShouldBe = searchIn.Length;
            Assert.AreEqual(9,result);
            Assert.IsTrue(_MaxTraialsShouldBe >= actualTrials);
        }
        [Test]
        public void ArrayExistingElementReturnsTheElementIndex2 ()
        {
            const int elementsCountInArray = 10000000;
            var arr = Enumerable.Range(10, elementsCountInArray).ToArray(); ;

            var result = SimpleSearch<int>.LineSearch(arr, 10000009 , out int actualTrials);
            int _MaxTraialsShouldBe =  arr.Length+1;
           
            Assert.AreEqual(9999999,result);
            Assert.IsTrue(_MaxTraialsShouldBe >= actualTrials);
        }
        [Test]
        public void ArrayExistingElementReturnsTheCharIndex ()
        {
            var arr = new char[26];
            char a = 'A';
            for (int i = 0; i < 26; i++)
            {
                arr[i] = a++;
            }

            var result = SimpleSearch<char>.LineSearch(arr, 'Z', out int actualTrials);
            int _MaxTraialsShouldBe = arr.Length + 1;
            Console.WriteLine(result + "," + actualTrials);
            Assert.AreEqual(25, result);
            Assert.IsTrue(_MaxTraialsShouldBe >= actualTrials);
        }
        [Test]
        public void ArrayExistingElementReturnsTheStringIndex ()
        {
            
            var arr = new string[] {"ahmed" , "samir" , "abdelaal" , "foo","par" } ;

            var result = SimpleSearch<string>.LineSearch(arr, "foo", out int actualTrials);
            int _MaxTraialsShouldBe = arr.Length + 1;

            Assert.AreEqual(3, result);
            Assert.IsTrue(_MaxTraialsShouldBe >= actualTrials);
        }
        [Test]
        public void TrialsCountInWortstCaseIsArrayLengthPlusOneIfFoundOrLess () {
            const int elementsCountInArray = 10000000;
            var arr = Enumerable.Range(10, elementsCountInArray).ToArray(); ;

            var result = SimpleSearch<int>.LineSearch(arr, 10000009, out int actualTrials);
            int _MaxTraialsShouldBe =  arr.Length+1;

            Assert.AreEqual(9999999, result);
            Assert.IsTrue(_MaxTraialsShouldBe>= actualTrials);
        }

        [Test]
        public void TrialsCountInWortstCaseIsArrayLengthPlusOneIfNotFoundOrLessAndReturnsMinusOne ()
        {
            const int elementsCountInArray = 10000000;
            var arr = Enumerable.Range(10, elementsCountInArray).ToArray(); ;

            var result = SimpleSearch<int>.LineSearch(arr, 5, out int actualTrials);
            int _MaxTraialsShouldBe = arr.Length+1;

            Assert.AreEqual(-1, result);
            Assert.IsTrue(_MaxTraialsShouldBe >= actualTrials);
        }
    }
}
