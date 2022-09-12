using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

namespace Tests
{
    public class FactTest
    {
        [Test]
        public void FactSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = Fact.outputFact(input);
            int[] expected = { 24, 2, 40320, 6, 362880, 24, 3628800 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
