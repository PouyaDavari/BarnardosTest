
using System.Linq;
using System.Text;

namespace BarnardosTest
{
    public class PuzzleOne
    {
        /// <summary>
        /// Reverses words in a sentence
        /// </summary>
        public string ReverseWords(string sentence)
        {
            var words = sentence.Split(' ').ToList();
            var strBuilder = new StringBuilder(sentence);

            words.ForEach(word =>
                strBuilder.Replace(word, ReverseString(word)));

            return strBuilder.ToString();
        }

        /// <summary>
        /// Reverses a string
        /// </summary>
        private string ReverseString(string str)
        {
            var strBuilder = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                strBuilder.Append(str[i]);
            }

            return strBuilder.ToString();
        }
    }
}
