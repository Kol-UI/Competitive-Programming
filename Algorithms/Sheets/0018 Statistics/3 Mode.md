Return the value with the high frequency from a list. If there are multiple modes, return the first one.

```cs
public class Mode
{
    // Approach 1: Dictionary frequency count
    public double ComputeDictionary(IEnumerable<double> numbers)
    {
        var list = numbers.ToList();
        if (list.Count == 0) throw new ArgumentException("Collection cannot be empty.");

        var freq = new Dictionary<double, int>();
        foreach (var n in list)
        {
            freq.TryGetValue(n, out int count);
            freq[n] = count + 1;
        }

        // First encountered with max frequency
        int maxFreq = freq.Values.Max();
        foreach (var n in list)
            if (freq[n] == maxFreq) return n;

        throw new InvalidOperationException("Unreachable.");
    }

    // Approach 2: LINQ GroupBy
    public double ComputeLinq(IEnumerable<double> numbers)
    {
        var list = numbers.ToList();
        if (list.Count == 0) throw new ArgumentException("Collection cannot be empty.");

        int maxFreq = list.GroupBy(x => x).Max(g => g.Count());

        // Preserve first-encountered order
        return list.First(n => list.Count(x => x == n) == maxFreq);
    }

    // Approach 3: Sort-based (consecutive equal values)
    public double ComputeSorted(IEnumerable<double> numbers)
    {
        var list = numbers.ToList();
        if (list.Count == 0) throw new ArgumentException("Collection cannot be empty.");

        // Map each value to its original first index to restore first-seen order later
        var firstIndex = new Dictionary<double, int>();
        for (int i = 0; i < list.Count; i++)
            firstIndex.TryAdd(list[i], i);

        var sorted = list.OrderBy(x => x).ToList();

        double mode = sorted[0];
        int maxFreq = 1, curFreq = 1;

        for (int i = 1; i < sorted.Count; i++)
        {
            if (sorted[i] == sorted[i - 1])
            {
                curFreq++;
                if (curFreq > maxFreq ||
                   (curFreq == maxFreq && firstIndex[sorted[i]] < firstIndex[mode]))
                {
                    maxFreq = curFreq;
                    mode = sorted[i];
                }
            }
            else
            {
                curFreq = 1;
            }
        }

        return mode;
    }
}```