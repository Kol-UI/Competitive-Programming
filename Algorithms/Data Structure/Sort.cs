namespace CompetitiveProgramming.Algorithms;

public class Sort
{
    // Comparison to sorting

    // Sort numbers in descending order
    // .Sort() for ascending order
    public static List<int> SortNumbersDescending(List<int> numbers)
    {
        numbers.Sort((a, b) => b.CompareTo(a));
        return numbers;
    }

    // Sort a list of strings in reverse alphabetical order (descending)
    // .Sort() for ascending order
    public static List<string> SortStringsAlphabeticalyReversed(List<string> words)
    {
        words.Sort((a, b) => string.Compare(b, a, StringComparison.Ordinal));
        return words;
    }

    // Sort by string length
    public static List<string> SortByStringLength(List<string> words)
    {
        words.Sort((a, b) => a.Length.CompareTo(b.Length));
        return words;
    }

    // Sort a list of integers by the sum of their digits
    public static List<int> SortBySumOfDigits(List<int> numbers)
    {
        numbers.Sort((a, b) => SumOfDigits(a).CompareTo(SumOfDigits(b)));
        return numbers;
    }

    private static int SumOfDigits(int n) =>  n.ToString().Sum(c => c - '0');

    // Sort a list of strings by frequency of specific characters
    public static List<string> SortByFrequencyCharacters(List<string> words, char c)
    {
        words.Sort((a, b) => CountOccurrences(a, c).CompareTo(CountOccurrences(b, c)));
        return words;
    }

    private static int CountOccurrences(string s, char c) => s.Count(ch => ch == c);

    // Sort a list of tuples by the first element
    public static List<(int, int)> SortTuplesByFirstElement(List<(int, int)> pairs)
    {
        pairs.Sort((a, b) => a.Item1.CompareTo(b.Item1));
        return pairs;
    }

    // Sort a list of tuples by the second element
    public static List<(int, int)> SortTuplesBySecondElement(List<(int, int)> pairs)
    {
        pairs.Sort((a, b) => a.Item2.CompareTo(b.Item2));
        return pairs;
    }
}