namespace CompetitiveProgramming.Algorithms;

public class HashingFrequency()
{
    public static Dictionary<int, int> GetFrequency(int[] nums)
    {
        Dictionary<int, int> frequencies = new();

        foreach (int number in nums)
        {
            if (frequencies.ContainsKey(number))
            {
                frequencies[number]++;
            }
            else
            {
                frequencies[number] = 1;
            }
        }

        //foreach (var pair in frequencies) Console.WriteLine($"Element {pair.Key} : {pair.Value} times");
        return frequencies;
    }

    public static (int, int) GetHighestFrequency(int[] nums)
    {
        Dictionary<int, int> frequencies = GetFrequency(nums);
        int highestFrequency = 0;
        int mostFrequentElement = 0;
        foreach (var pair in frequencies)
        {
            if (pair.Value > highestFrequency)
            {
                highestFrequency = pair.Value;
                mostFrequentElement = pair.Key;
            }
        }
        return (mostFrequentElement, highestFrequency);
    }

    public static (int, int) GetHighestFrequencyLinq(int[] nums)
    {
        var mostFrequent = nums
            .GroupBy(n => n)
            .OrderByDescending(g => g.Count())
            .First();

        return (mostFrequent.Key, mostFrequent.Count());
    }

    public static (int, int) GetLowestFrequency(int[] nums)
    {
        Dictionary<int, int> frequencies = GetFrequency(nums);
        int lowestFrequency = int.MaxValue;
        int leastFrequentElement = 0;
        foreach (var pair in frequencies)
        {
            if (pair.Value < lowestFrequency)
            {
                lowestFrequency = pair.Value;
                leastFrequentElement = pair.Key;
            }
        }
        return (leastFrequentElement, lowestFrequency);
    }

    public static (int, int) GetLowestFrequencyLinq(int[] nums)
    {
        var leastFrequent = nums
            .GroupBy(n => n)
            .OrderBy(g => g.Count())
            .First();

        return (leastFrequent.Key, leastFrequent.Count());
    }
}