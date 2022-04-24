using Katas.CodeKatas;
using NUnit.Framework;
using System.Collections.Generic;

/** http://codekata.com/kata/kata02-karate-chop/ */

namespace Tests
{
    [TestFixture]
    class GivenABinaryChopOnASortedArrayOfIntegersUsingTheIterativeApproach
    {

        private BinarySearchService _subject;

        [SetUp]
        public void Setup()
        {
            _subject = new BinarySearchService();
        }

        [Test]
        public void ThenTheCorrectIndexIsReturnedForTheRequestedItem()
        {
            Assert.AreEqual(_subject.ChopIterative(new List<int>(), 3), -1);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { -1 }, 3), -1);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1 }, 1), 0);

            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5 }, 1), 0);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5 }, 3), 1);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5 }, 5), 2);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5 }, 0), -1);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5 }, 2), -1);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5 }, 4), -1);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5 }, 6), -1);

            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5, 7 }, 1), 0);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5, 7 }, 3), 1);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5, 7 }, 5), 2);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5, 7 }, 7), 3);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5, 7 }, 0), -1);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5, 7 }, 2), -1);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5, 7 }, 4), -1);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5, 7 }, 6), -1);
            Assert.AreEqual(_subject.ChopIterative(new List<int> { 1, 3, 5, 7 }, 8), -1);
        }
    }
}
