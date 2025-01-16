using System.Text.Json;

namespace CompetitiveProgramming.Algorithms;

public class CyclicSequence
{
    #region CF 1454A
    // Generates a space-separated string of numbers from 1 to n.
    public static string GenerateCyclicSequence(int n)
    {
        return string.Join(" ", Enumerable.Range(0, n).Select(i => ((i + 1) % n + 1).ToString()));
    }
    #endregion

    // Generates cyclic sequence with separator
    public static string GenerateCyclicSequenceWithSeparator(int n, string separator)
    {
        return string.Join(separator, Enumerable.Range(0, n).Select(i => ((i + 1) % n + 1).ToString()));
    }

    // Generates a cyclic sequence of numbers from 1 to n repeated k times.
    public static string GenerateRepeatedCyclicSequence(int n, int k)
    {
        return string.Join(" ", Enumerable.Range(0, n * k).Select(i => (i % n + 1).ToString()));
    }

    // Returns the k-th element in a cyclic sequence from 1 to n.
    public static int GetElementInCyclicSequence(int n, int k)
    {
        return (k - 1) % n + 1;
    }

    // Checks if a number exists in a cyclic sequence from 1 to n.
    public static bool IsNumberInCyclicSequence(int n, int number)
    {
        return number >= 1 && number <= n;
    }

    // Generates a reversed cyclic sequence from n to 1.
    public static string GenerateReversedCyclicSequence(int n)
    {
        return string.Join(" ", Enumerable.Range(0, n).Select(i => (n - i).ToString()));
    }

    // Rotates a cyclic sequence of numbers from 1 to n by k steps.
    // 5 & 2
    // 1,2,3,4,5
    // returns 3,4,5,1,2 (pos+2)
    public static string RotateCyclicSequence(int n, int k)
    {
        return string.Join(" ", Enumerable.Range(0, n).Select(i => ((i + k) % n + 1).ToString()));
    }

    // Calculates the sum of a cyclic sequence from 1 to n.
    public static int SumCyclicSequence(int n)
    {
        return Enumerable.Range(1, n).Sum();
    }

    // Sequence into Dictionary
    public static Dictionary<int, int> GenerateCyclicSequenceDictionary(int n)
    {
        return Enumerable.Range(0, n).ToDictionary(i => i, i => ((i + 1) % n + 1));
    }

    // Sequence into HashSet
    public static HashSet<int> GenerateCyclicSequenceHashSet(int n)
    {
        return Enumerable.Range(0, n).Select(i => ((i + 1) % n + 1)).ToHashSet();
    }

    // Sequence into BinaryArray
    public static string[] GenerateCyclicSequenceBinaryArray(int n)
    {
        return Enumerable.Range(0, n).Select(i => Convert.ToString(((i + 1) % n + 1), 2)).ToArray();
    }

    // Sequence into Json
    public static string GenerateCyclicSequenceJson(int n)
    {
        var sequence = Enumerable.Range(0, n).Select(i => ((i + 1) % n + 1)).ToArray();
        return JsonSerializer.Serialize(sequence);
    }

    // Sequence squares :
    // 5 returns [1, 4, 9, 16, 25]
    public static int[] GenerateCyclicSequenceSquares(int n)
    {
        return Enumerable.Range(0, n).Select(i => (int)Math.Pow(((i + 1) % n + 1), 2)).ToArray();
    }
}