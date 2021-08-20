using System;
using System.Collections.Generic;
using System.Text;

namespace GrokkingAlgoExapmles
{
    /// <summary>
    /// The comparing  base class for comparable generic types .
    /// </summary>
    public class ComparingTBase<T> where T : IComparable<T>
    {
        /// <summary>
        /// Compares the.
        /// </summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        /// <returns>An int.</returns>
        private static int Compare (T a, T b)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            int compared = comparer.Compare(a, b);
            return compared;
        }

        // true if a > b 
        /// <summary>
        /// Are the bigger than.
        /// </summary>
        /// <param name="a">The a. main comparing member </param>
        /// <param name="b">The b. second / other comparing member </param>
        /// <returns>A boolean</returns>
        public static bool IsBiggerThan (T a, T b) { return Compare(a, b) >= 1; }

        public static bool IsEqualTo (T a, T b) { return Compare(a, b) == 0; }

        /// <summary>
        /// true if a < b
        /// </summary>
        /// <param name="a">The a. main comparing member</param>
        /// <param name="b">The b. second / other comparing member</param>
        /// <returns>A boolean</returns>
        public static bool IsLessThan (T a, T b) { return Compare(a, b) <= -1; }

        // An override of Equals(Object).
        public override bool Equals (Object obj)
        {
            if (obj is T node)
                return Equals(node);
            return false;
        }
    }
}
