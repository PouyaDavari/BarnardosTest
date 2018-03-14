using System;

using NUnit.Framework;

namespace BarnardosTest.test
{
    [TestFixture]
    class PuzzleTwoTests
    {
        /// <summary>
        /// PdLinkedList returns fifth element correctly
        /// </summary>
        [Test]
        public void PdLinkedList_ReturnsFifthNodeCorrectly()
        {
            // Arrange            
            var pdLinkedList = new PdLinkedList<int>();

            // Act
            pdLinkedList.Add(2);
            pdLinkedList.Add(3);
            pdLinkedList.Add(4);
            pdLinkedList.Add(5);
            pdLinkedList.Add(6);
            pdLinkedList.Add(7);
            pdLinkedList.Add(8);
            pdLinkedList.Add(9);
            pdLinkedList.Add(10);
            pdLinkedList.Add(11);

            int result = pdLinkedList[5];
            int expected = 7;

            // Assert
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void PdLinkList_InvalidIndexRetrnsException()
        {
            // Arrange
            var pdLinkedList = new PdLinkedList<int>();

            // Act
            pdLinkedList.Add(1);

            // Assert            
            Assert.That(() => pdLinkedList[5],
                Throws.TypeOf<IndexOutOfRangeException>());
        }
    }
}
