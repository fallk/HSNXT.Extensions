namespace HSNXT.Test
{
    using NUnit.Framework;

    /// <summary>
    /// Verify the behavior of the Slice operator
    /// </summary>
    [TestFixture]
    public class SliceTests
    {
        /// <summary>
        /// Verify that Slice evaluates in a lazy manner.
        /// </summary>
        [Test]
        public void TestSliceIsLazy()
        {
            new BreakingSequence<int>().Slice(10, 10);
        }

        /// <summary>
        /// Verify that a slice from 0 to sequence.Count() yields the source sequence.
        /// NOTE: Since there are two different implementations of Slice() - one optimized that's
        ///       for lists and one that operates on any <c>IEnumerable{T}</c>, this test examines both.
        /// </summary>
        [Test]
        public void TestSliceIdentity()
        {
            const int count = 100;
            var sequenceA = Enumerable.Range(1, count);
            var sequenceB = sequenceA.ToList();

            var resultA = sequenceA.Slice(0, count);
            var resultB = sequenceB.Slice(0, count);

            Assert.IsTrue(resultA.SequenceEqual(sequenceA));
            Assert.IsTrue(resultB.SequenceEqual(sequenceB));
        }

        /// <summary>
        /// Verify that Slice can yield just the first item.
        /// NOTE: Since there are two different implementations of Slice() - one optimized that's
        ///       for lists and one that operates on any <c>IEnumerable{T}</c>, this test examines both.
        /// </summary>
        [Test]
        public void TestSliceFirstItem()
        {
            const int count = 10;
            var sequenceA = Enumerable.Range(1, count);
            var sequenceB = sequenceA.ToList();
            var resultA = sequenceA.Slice(0, 1);
            var resultB = sequenceB.Slice(0, 1);

            Assert.IsTrue(resultA.SequenceEqual(sequenceA.Take(1)));
            Assert.IsTrue(resultB.SequenceEqual(sequenceB.Take(1)));
        }

        /// <summary>
        /// Verify that Slice yields the correct set of items when it
        /// extends past the end of the source sequence.
        /// NOTE: Since there are two different implementations of Slice() - one optimized that's
        ///       for lists and one that operates on any <c>IEnumerable{T}</c>, this test examines both.
        /// </summary>
        [Test]
        public void TestSliceLongerThanSequence()
        {
            const int count = 100;
            var sequenceA = Enumerable.Range(1, count);
            var sequenceB = sequenceA.ToList();
            var resultA = sequenceA.Slice(count / 2, count);
            var resultB = sequenceB.Slice(count / 2, count);

            Assert.IsTrue(resultA.SequenceEqual(sequenceA.Skip(count / 2).Take(count)));
            Assert.IsTrue(resultB.SequenceEqual(sequenceB.Skip(count / 2).Take(count)));
        }
    }
}