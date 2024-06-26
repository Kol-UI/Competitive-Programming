using System.Text.RegularExpressions;

namespace CompetitiveProgramming.Helpers
{
    public class StringUtils
    {
        // Return number of unique char in a string
        // "test" => 3
        public static int GetNumberOfUniqueCharInString(string s)
        {
            return s.ToHashSet().Count;
        }

        // Reverse a string
        // "test" => "tset"
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Count occurences in string
        // "Hello, World!" & "World" => 1
        public static int CountOccurrences(string input, string substring)
        {
            int count = 0;
            int index = input.IndexOf(substring, StringComparison.Ordinal);
            while (index != -1)
            {
                count++;
                index = input.IndexOf(substring, index + 1, StringComparison.Ordinal);
            }
            return count;
        }

        // Check if string is palindrome
        public static bool IsPalindrome(string input)
        {
            string cleanedInput = new string(input.Where(char.IsLetterOrDigit).ToArray());
            string reversed = ReverseString(cleanedInput);
            return cleanedInput.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        // Check if strings are egal while ignoring case
        public static bool AreStringsEgalIgnoreCase(string string1, string string2)
        {
            return String.Equals(string1, string2, StringComparison.OrdinalIgnoreCase);
        }

        // Check if string ends with another one
        // "test" "est" => true
        public static bool CheckIfEndsWith(string str, string ending)
        {
            return str.EndsWith(ending);
        }

        // Remove letters from a string => "[aeuoi]" will be remove from str, also works with case
        public static string RemoveLettersFromString(string str, string toRemove) => Regex.Replace(str, "[" + toRemove + "]", string.Empty, RegexOptions.IgnoreCase);

        // Check if pin is 4 or 6 digits
        public static bool IsValidPinLength(string pin) => pin.All(char.IsDigit) && (pin.Length == 6 || pin.Length == 4);

        // Convert a String Array to a Sentence with space between words
        public static string ConvertArrayToSentence(string[] words)
        {
            return words.Length >= 1 ? string.Join(" ", words) : "";
        }
    }
}