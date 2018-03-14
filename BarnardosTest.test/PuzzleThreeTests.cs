using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BarnardosTest.test
{
    [TestFixture]
    class PuzzleThreeTests
    {

        /// <summary>
        /// Returns correct triangleType type
        /// </summary>
        [TestCase(7, 7, 7, TriangleType.Equilateral)]
        [TestCase(7, 7, 6, TriangleType.Isosceles)]
        [TestCase(7, 6, 5, TriangleType.Scalene)]
        public void TriangleType_ReturnsCorrectType(int side1, int side2, int side3
            , TriangleType expectedType)
        {
            // Arrange
            var puzzleThree = new PuzzleThree();

            // Act
            var result = puzzleThree.GetTriangleType(side1, side2, side3);

            // Assert
            Assert.AreEqual(expectedType, result);
        }

        /// <summary>
        /// Invalid sides throw exception
        /// </summary>
        [TestCase(0, 1, 2)]
        [TestCase(1, -1, 7)]
        public void TriangleType_InvalidSidesThrowException(int side1, int side2, int side3)
        {
            // Arrange
            var puzzleThree = new PuzzleThree();

            // Act            
            // Assert            
            Assert.That(() => puzzleThree.GetTriangleType(side1, side2, side3),
                Throws.TypeOf<Exception>());
        }
    }
}
