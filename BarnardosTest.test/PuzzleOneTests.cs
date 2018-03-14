
using NUnit.Framework;

namespace BarnardosTest.test
{
    [TestFixture]
    class PuzzleOneTests
    {        
        [TestCase("never give up", "reven evig pu")]
        [TestCase("2*2=4 ,7*9!=(67)", "4=2*2 )76(=!9*7,")]        
        public void ReverseWordsTest(string sentence, string expectedSentence)
        {
            // Arange
            var puzzleOne = new PuzzleOne();

            // Act
            var reversedSentence = puzzleOne.ReverseWords(sentence);

            // Assert
            Assert.AreEqual(expectedSentence, reversedSentence);
        }
    }
}
