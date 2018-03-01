using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptarithms
{
    class CryptarithmicPuzzle
    {
        // Array containing arithmic question.
        // Array of Letter Variables to adjust.
        // String of original input.
        // 

        private string puzzleString;
        private List<char> puzzleLetters;
        private string puzzleEquation;

        public struct LetterValPair
        {
            // TODO: Getter and Setters
            public char letter;
            public int value;
        }

        public CryptarithmicPuzzle(string Puzzle)
        {
            puzzleString = Puzzle;
            puzzleLetters = extractVariables(Puzzle);
        }

        private List<char> extractVariables(string puzzleString)
        {

            List<char> variables = new List<char>();
            for (int i = 0; i < puzzleString.Length; i++)
            {
                // Get char and check if valid Letter
                char c = puzzleString[i];
                if (!Char.IsLetter(c)) continue;

                bool exists = false;
                // Check to see if letter is already recorded
                foreach (char item in variables)
                {
                    // If Exists, Skip loop and continue
                    if (item.Equals(c))
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    variables.Add(c);

                }
            }

            return variables; 
        }

    }
}
