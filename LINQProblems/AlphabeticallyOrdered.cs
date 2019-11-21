using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class AlphabeticallyOrdered
    {
        public static string PrintStringAlphabetically(string stringOfLetters)
        {
            stringOfLetters = stringOfLetters.ToUpper();
            char[] charactersToBeAlphabetized = stringOfLetters.ToCharArray();
            Array.Sort(charactersToBeAlphabetized);
            StringBuilder lettersAlphabetized = new StringBuilder();
            lettersAlphabetized.Append(charactersToBeAlphabetized);
            return lettersAlphabetized.ToString();
        }
        public static List<string> NumberOfEachChar(string lettersAlphabetized)
        {
            List<string> output = new List<string>();
            var groupedLetters = lettersAlphabetized.GroupBy(l => l);
            foreach(var letter in groupedLetters)
            {
                output.Add(letter.Key.ToString());
                output.Add(letter.Count().ToString());
            }
            return output;
        }
        public static string ReturnedString(List<string> input)
        {
            string result = string.Join("", input);
            return result;
        }

    }
}
