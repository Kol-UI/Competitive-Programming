namespace CompetitiveProgramming.Algorithms;
/*
A happy string is a string that:

consists only of letters of the set ['a', 'b', 'c'].
s[i] != s[i + 1] for all values of i from 1 to s.length - 1 (string is 1-indexed).
For example, strings "abc", "ac", "b" and "abcbabcbcb" are all happy strings and strings "aa", "baa" and "ababbc" are not happy strings.
*/
public class HappyString
{
    private static List<string> GenerateHappyStrings(int n, HashSet<char> charSet)
    {
        List<string> happyStrings = new List<string>();
        GenerateHappyStringsRecursive(n, "", happyStrings, charSet);
        return happyStrings;
    }

    private static void GenerateHappyStringsRecursive(int n, string current, List<string> result, HashSet<char> charSet)
    {
        if (current.Length == n)
        {
            result.Add(current);
            return;
        }

        char lastChar = current.Length > 0 ? current[current.Length - 1] : '\0';
        foreach (char c in charSet)
        {
            if (c != lastChar)
            {
                GenerateHappyStringsRecursive(n, current + c, result, charSet);
            }
        }
    }

    private static bool IsHappyString(string s, HashSet<char> charSet)
    {
        foreach (char c in s)
        {
            if (!charSet.Contains(c))
                return false;
        }

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1])
                return false;
        }

        return true;
    }

    private static List<string> SortHappyStrings(List<string> happyStrings)
    {
        happyStrings.Sort();
        return happyStrings;
    }

    private static string GetKthHappyString(List<string> happyStrings, int k)
    {
        if (k > happyStrings.Count || k <= 0)
            return "";
        return happyStrings[k - 1];
    }

    private static List<char> GetNextHappyChar(char lastChar, HashSet<char> charSet)
    {
        List<char> nextChars = new List<char>();
        foreach (char c in charSet)
        {
            if (c != lastChar)
                nextChars.Add(c);
        }
        return nextChars;
    }
}