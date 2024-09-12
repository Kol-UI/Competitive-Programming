namespace CompetitiveProgramming.Algorithms
{
    public class StringManipulation
    {
        #region LC 1945
        public static string ConvertStringToAlphabetPosition(string s)
        {
            string numericString = "";
            foreach (char letter in s)
            {
                numericString += GetAlphabetIndex(letter).ToString();
            }
            return numericString;
        }

        private static int GetAlphabetIndex(char inputChar)
        {
            char lowerChar = char.ToLower(inputChar);
            return lowerChar - 'a' + 1;
        }
        #endregion

        #region LC 1684
        private static HashSet<char> CreateCharacterSet(string allowed)
        {
            return new HashSet<char>(allowed);
        }

        private static bool IsStringContainsChar(string word, HashSet<char> allowedSet)
        {
            return word.All(character => allowedSet.Contains(character));
        }
        #endregion
    }
}