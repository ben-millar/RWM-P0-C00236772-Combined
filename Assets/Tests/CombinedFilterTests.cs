using NUnit.Framework;
using UnityEngine;

namespace CombinedFilterTests
{
    public class CombinedFilterTests
    {
        [Test]
        public void combinedTest()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = CombinedFilter.combinedFilter(input);

            // { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 } => Decrement if less than first
            // { 4, 1, 8, 2, 9, 4, 10, 5, 11, 6 } => Mod by number at first index
            // { 0, 1, 0, 2, 1, 0, 2, 1, 3, 2 }
            int[] expected = { 0, 1, 0, 2, 1, 0, 2, 1, 3, 2 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}