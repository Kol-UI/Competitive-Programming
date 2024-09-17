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

        public static bool IsAnagram(string s, string t)
        {
            char[] ss = s.ToCharArray();
            char[] tt = t.ToCharArray();

            Array.Sort(ss);
            Array.Sort(tt);
            
            return new string(ss) == new string(tt);
        }

        public static string GetAbbrevName(string name)
        {
            string[] names = name.Split(' ');
            return $"{char.ToUpper(names[0][0])}.{char.ToUpper(names[1][0])}";
        }

        public static bool IsStringUppercase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }

            return input == input.ToUpper();
        }

        public static int GetStringLength(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            return input.Length;
        }
    }
}