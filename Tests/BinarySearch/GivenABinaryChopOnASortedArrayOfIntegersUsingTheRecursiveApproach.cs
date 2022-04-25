using Katas.CodeKatas;
using NUnit.Framework;
using System.Collections.Generic;

/** http://codekata.com/kata/kata02-karate-chop/ */

namespace Tests
{
    [TestFixture]
    class GivenABinaryChopOnASortedArrayOfIntegersUsingTheRecursivceApproach
    {
        [Test]
        public void ThenTheCorrectIndexIsReturnedForTheRequestedItem()
        {
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int>(), 3, null, null), -1);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { -1 }, 3, null, null), -1);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1 }, 1, null, null), 0);

            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5 }, 1, null, null), 0);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5 }, 3, null, null), 1);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5 }, 5, null, null), 2);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5 }, 0, null, null), -1);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5 }, 2, null, null), -1);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5 }, 4, null, null), -1);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5 }, 6, null, null), -1);

            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5, 7 }, 1, null, null), 0);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5, 7 }, 3, null, null), 1);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5, 7 }, 5, null, null), 2);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5, 7 }, 7, null, null), 3);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5, 7 }, 0, null, null), -1);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5, 7 }, 2, null, null), -1);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5, 7 }, 4, null, null), -1);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5, 7 }, 6, null, null), -1);
            Assert.AreEqual(BinarySearchService.ChopRecursively(new List<int> { 1, 3, 5, 7 }, 8, null, null), -1);
        }
    }
}
