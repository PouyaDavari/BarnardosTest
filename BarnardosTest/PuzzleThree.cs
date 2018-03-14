using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BarnardosTest
{
    public enum TriangleType : byte
    {
        Equilateral = 0,
        Isosceles = 1,
        Scalene = 2
    }

    public class PuzzleThree
    {
        /// <summary>
        /// Get triangle type
        /// </summary>
        /// <returns>TriangleType</returns>
        public TriangleType GetTriangleType(int side1, int side2, int side3)
        {
            var sides = new List<int> { side1, side2, side3 };

            if (sides.Any(s => s <= 0))
                throw new Exception("Invalid sides");

            switch (sides.Distinct().Count())
            {
                case 1:
                    return TriangleType.Equilateral;
                case 2:
                    return TriangleType.Isosceles;
                case 3:
                    return TriangleType.Scalene;
                default:
                    throw new Exception("Invalid sides");
            }
        }
    }
}
