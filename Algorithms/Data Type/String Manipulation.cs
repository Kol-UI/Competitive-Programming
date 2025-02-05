using System.Text;

namespace CompetitiveProgramming.Algorithms
{
    public class StringManipulation
    {
        #region 214
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        #endregion

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
            if(s.Length != t.Length) return false;
            
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

        public static string InverseCase(string input)
        {
            string result = string.Empty;

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    result += char.ToLower(c);
                }
                else
                {
                    result += char.ToUpper(c);
                }
            }

            return result;
        }

        #region LC 884
        public static List<string> SplitSentenceIntoWords(string sentence)
        {
            return sentence.Split(' ').ToList();
        }
        #endregion

        #region CW Convert a string to an array
        // "Hello World" => new string[]{"Hello", "World"}
        public static string[] StringToArray(string str)
        {
            return str.Split(' ');
        }
        #endregion

        #region LC 917
        private static bool IsLetter(in char ch) => (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z');
        #endregion

        #region LC557
        // Reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order
        public string ReverseWordsInSentence(string s)
        {
            var arrayOfWords = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder reversedString = new StringBuilder("");

            foreach (var word in arrayOfWords)
            {            
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);

                reversedString.Append(" " + new string(charArray));
            }

            string result = reversedString.ToString().Substring(1);

            return result;
        }
        #endregion

        #region LC 434
        // Each segment is separated by space
        public int CountSegments(string s)
        {
            int segments = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsWhiteSpace(s[i]) && (i == 0 || char.IsWhiteSpace(s[i - 1])))
                {
                    segments++;
                }
            }

            return segments;
        }
        #endregion
    }
}