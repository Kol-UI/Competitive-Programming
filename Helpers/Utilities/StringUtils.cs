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
    }
}