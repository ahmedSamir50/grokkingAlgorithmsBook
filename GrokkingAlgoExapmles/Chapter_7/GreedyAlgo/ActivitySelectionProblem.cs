using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GrokkingAlgoExapmles.Chapter_7.GreedyAlgo
{
    /// <summary>
    /// Example 1 : Consider the following 3 activities sorted by
    ///    by finish time.
    ///         start[]  =  {10, 12, 20};
    ///finish[] =  { 20, 25, 30};
    ///A person can perform at most two activities. The 
    ///maximum set of activities that can be executed 
    ///is {0, 2} [These are indexes in start[] and
    ///finish[] ]
    ///Example 2 : Consider the following 6 activities 
    ///sorted by by finish time.
    ///     start[]  =  { 1, 3, 0, 5, 8, 5};
    ///finish[] =  { 2, 4, 6, 7, 9, 9};
    ///A person can perform at most four activities. The 
    ///maximum set of activities that can be executed 
    ///is {0, 1, 3, 4} [These are indexes in start[] and
    ///finish[] ]
    /// </summary>
    public  class ActivitySelectionProblem
    {
        public static int[] SelectMaxActivitiesIfSorted(int[] start , int[] finish , short maxActivitiesNeeded=1 ) {
            int i, j;
            // first activity is always selected 
            i = 0;
            List<int> selectedActivities = new List<int>() { 0};
            for (j = 1; j <= maxActivitiesNeeded;j++) {
                // if the start of activity > finish of last selected activity 
                // conseder as selected Activity
                if (start[j] >= finish[i])
                {
                    i = j;
                    selectedActivities.Add(i);
                }
            }
            return selectedActivities.ToArray();
        }

        public static int[] SelectMaxActivitiesNotSorted(int[] start, int[] finish, short maxActivitiesNeeded = 1)
        {
            // Sort Activities By Finish Time 
            List<ActivitySelection> intoActivities = new List<ActivitySelection>();
            for (int elem = 0; elem < finish.Length; elem++)
                intoActivities.Add(new ActivitySelection() {StartTime = start[elem], FinishTime = finish[elem] });

            int i = 0;
            List<int> selectedActivities = new List<int>() { 0 };
            int j;
            for (j = 1; j <= maxActivitiesNeeded; j++)
            {
                // if the start of activity > finish of last selected activity 
                // conseder as selected Activity
                if (intoActivities[j].StartTime >= intoActivities[i].FinishTime)
                {
                    i = j;
                    selectedActivities.Add(i);
                }
            }
            return selectedActivities.ToArray();
        }
    }
    public static class ActivitySortesExtention
        {
            public static void ActivitySorter(this ActivitySelection[] _)
            {
                Array.Sort(_, (x,y)=> { return x.FinishTime - y.FinishTime; });
            }
        }
}
