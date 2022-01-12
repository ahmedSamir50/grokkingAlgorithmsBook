using System.Collections.Generic;

namespace GrokkingAlgoExapmles.Chapter_7.GreedyAlgo
{
    class ActivityComparer : Comparer<ActivitySelection>
    {
        public override int Compare(ActivitySelection ActivityA, ActivitySelection ActivityB)
        {
            return ActivityA.FinishTime - ActivityB.FinishTime;
        }
    }

}
