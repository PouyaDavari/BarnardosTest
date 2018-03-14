using System;

namespace BarnardosTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reverse words
            var puzzleOne=new PuzzleOne();

            Console.WriteLine(puzzleOne.ReverseWords("this is a test sentence"));

            // PdLinkedList
            var pdLinkedList = new PdLinkedList<int>();

            pdLinkedList.Add(1);
            pdLinkedList.Add(2);
            pdLinkedList.Add(3);
            
            Console.WriteLine(pdLinkedList[1]);

            // TriangleType
            var puzzleThree = new PuzzleThree();
            var result = puzzleThree.GetTriangleType(7, 7, 6);
            Console.WriteLine(result.ToString());

            Console.ReadLine();
        }
    }
}
