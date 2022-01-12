using GrokkingAlgoExapmles.Chapter_7.GreedyAlgo;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrokkingAlgoTests.Chapter_7Tests.GreedyTests
{
    class ActivitySelectionProblemTests
    {

        [TestCase(new int[]{ 1, 3, 0, 5, 8, 5 } , new int[] { 2, 4, 6, 7, 9, 9 },4, new int[] { 0, 1, 3, 4 })]
        [TestCase(new int[] { 10, 12, 20 }, new int[] { 20, 25, 30 }, 2, new int[] { 0, 2 })]
        public void TestWhenActivitiesSorted(int[] startTimes , int[]finishTimes , short toSelectCount,int[] expectedSelections) {

            int[] results =  ActivitySelectionProblem.SelectMaxActivitiesIfSorted(startTimes, finishTimes, toSelectCount);
            Assert.AreEqual(expectedSelections, results);
           
        }

        [TestCase(new int[] { 1, 3, 0, 5, 8, 5 }, new int[] { 2, 4, 6, 7, 9, 9 }, 4, new int[] { 0, 1, 3, 4 })]
        [TestCase(new int[] { 10, 12, 20 }, new int[] { 20, 25, 30 }, 2, new int[] { 0, 2 })]
        public void TestWhenActivitiesNotSorted(int[] startTimes, int[] finishTimes, short toSelectCount, int[] expectedSelections) {
            int[] results = ActivitySelectionProblem.SelectMaxActivitiesNotSorted(startTimes, finishTimes, toSelectCount);
            Assert.AreEqual(expectedSelections, results);
        }
    }
}
