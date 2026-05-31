using System.Text;
using System.Text.RegularExpressions;

namespace CompetitiveProgramming.Algorithms;

public class Unique
{
    public char? FirstUniqueChar { get; set; }
    public char? LastUniqueChar { get; set; }
    public char? FirstUniqueDigit { get; set; }
    public char? LastUniqueDigit { get; set; }
    public string? FirstUniqueWord { get; set; }
    public string? LastUniqueWord { get; set; }
}

// Linq Approach
public class FirstUniquevsLastUniqueLinq
{
    public static Unique GetUniques(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence)) return new Unique();

        var (firstChar, lastChar) = ExtractUniqueChars(sentence);
        var (firstDigit, lastDigit) = ExtractUniqueDigits(sentence);
        var (firstWord, lastWord) = ExtractUniqueWords(sentence);

        return new Unique
        {
            FirstUniqueChar = firstChar,
            LastUniqueChar = lastChar,
            FirstUniqueDigit = firstDigit,
            LastUniqueDigit = lastDigit,
            FirstUniqueWord = firstWord,
            LastUniqueWord = lastWord
        };
    }

    // Logic for Characters
    private static (char? first, char? last) ExtractUniqueChars(string input)
    {
        var chars = input.Where(c => !char.IsWhiteSpace(c)).ToList();
        var counts = chars.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        
        var uniques = chars.Where(c => counts[c] == 1).ToList();
        return (uniques.FirstOrDefault(), uniques.LastOrDefault());
    }

    // Logic for Digits
    private static (char? first, char? last) ExtractUniqueDigits(string input)
    {
        var digits = input.Where(char.IsDigit).ToList();
        var counts = digits.GroupBy(d => d).ToDictionary(g => g.Key, g => g.Count());

        var uniques = digits.Where(d => counts[d] == 1).ToList();
        return (uniques.FirstOrDefault(), uniques.LastOrDefault());
    }

    // Logic for Words
    private static (string? first, string? last) ExtractUniqueWords(string input)
    {
        // Using Regex to identify words and ignore punctuation
        var words = Regex.Matches(input.ToLower(), @"\b\w+\b")
                         .Select(m => m.Value)
                         .ToList();

        var counts = words.GroupBy(w => w).ToDictionary(g => g.Key, g => g.Count());

        var uniques = words.Where(w => counts[w] == 1).ToList();
        return (uniques.FirstOrDefault(), uniques.LastOrDefault());
    }
}

// Manual Approach
public class FirstUniquevsLastUniqueManual
{
    public static Unique GetUniques(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence)) return new Unique();

        var (firstChar, lastChar) = ExtractUniqueChars(sentence);
        var (firstDigit, lastDigit) = ExtractUniqueDigits(sentence);
        var (firstWord, lastWord) = ExtractUniqueWords(sentence);

        return new Unique
        {
            FirstUniqueChar = firstChar,
            LastUniqueChar = lastChar,
            FirstUniqueDigit = firstDigit,
            LastUniqueDigit = lastDigit,
            FirstUniqueWord = firstWord,
            LastUniqueWord = lastWord
        };
    }

    // Manual Logic for Characters
    private static (char? first, char? last) ExtractUniqueChars(string input)
    {
        var counts = new Dictionary<char, int>();
        var order = new List<char>();

        foreach (char c in input)
        {
            if (char.IsWhiteSpace(c)) continue;

            if (!counts.ContainsKey(c))
            {
                counts[c] = 1;
                order.Add(c);
            }
            else counts[c]++;
        }

        return FindFirstAndLast(order, counts);
    }

    // Manual Logic for Digits
    private static (char? first, char? last) ExtractUniqueDigits(string input)
    {
        var counts = new Dictionary<char, int>();
        var order = new List<char>();

        foreach (char c in input)
        {
            if (!char.IsDigit(c)) continue;

            if (!counts.ContainsKey(c))
            {
                counts[c] = 1;
                order.Add(c);
            }
            else counts[c]++;
        }

        return FindFirstAndLast(order, counts);
    }

    // Manual Logic for Words (Processing word by word without Split/Regex)
    private static (string? first, string? last) ExtractUniqueWords(string input)
    {
        var counts = new Dictionary<string, int>();
        var order = new List<string>();
        var currentWord = new StringBuilder();

        // Process including a final character check to handle the last word
        for (int i = 0; i <= input.Length; i++)
        {
            char c = (i < input.Length) ? input[i] : ' '; // Fake space at end to trigger word save

            if (char.IsLetterOrDigit(c))
            {
                currentWord.Append(char.ToLower(c));
            }
            else if (currentWord.Length > 0)
            {
                string word = currentWord.ToString();
                if (!counts.ContainsKey(word))
                {
                    counts[word] = 1;
                    order.Add(word);
                }
                else counts[word]++;
                
                currentWord.Clear();
            }
        }

        return FindFirstAndLast(order, counts);
    }

    // Helper to extract first/last from frequency map
    private static (T? first, T? last) FindFirstAndLast<T>(List<T> order, Dictionary<T, int> counts) where T : class
    {
        T? first = null;
        T? last = null;

        foreach (var item in order)
        {
            if (counts[item] == 1)
            {
                if (first == null) first = item;
                last = item; // Keep updating to get the last one
            }
        }
        return (first, last);
    }

    // Overload for char? (Value types)
    private static (char? first, char? last) FindFirstAndLast(List<char> order, Dictionary<char, int> counts)
    {
        char? first = null;
        char? last = null;

        foreach (var item in order)
        {
            if (counts[item] == 1)
            {
                if (first == null) first = item;
                last = item;
            }
        }
        return (first, last);
    }
}