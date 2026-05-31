namespace CompetitiveProgramming.Algorithms;
#pragma warning disable CS8714
public class KthLeastFrequentElement
{
    // LINQ Approach
    public static T GetKthLeastFrequentLinq<T>(IEnumerable<T> list, int k)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        if (k <= 0) throw new ArgumentOutOfRangeException(nameof(k), "K must be at least 1.");

        var result = list
            .GroupBy(x => x)
            .OrderBy(g => g.Count())   // Ascending order (least frequent first)
            .ThenBy(g => g.Key)        // Stability: alphabetical/numerical order
            .Select(g => g.Key)
            .Skip(k - 1)               // Jump to the K-th element
            .Cast<object>()            // Cast to object to handle potential nulls in T
            .FirstOrDefault();

        if (result == null && list.GroupBy(x => x).Count() < k)
            throw new InvalidOperationException($"Not enough unique elements to find rank K={k}.");

        return (T)result!;
    }

    // Manual Approach
    public static T GetKthLeastFrequentManual<T>(IEnumerable<T> list, int k)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        if (k <= 0) throw new ArgumentOutOfRangeException(nameof(k), "K must be at least 1.");

        // Step 1: Count occurrences in a Dictionary
        var counts = new Dictionary<T, int>();
        foreach (var item in list)
        {
            if (counts.ContainsKey(item)) counts[item]++;
            else counts[item] = 1;
        }

        if (counts.Count < k)
            throw new InvalidOperationException($"Not enough unique elements to find rank K={k}.");

        // Step 2: Sort the dictionary entries by Value (Frequency)
        var sortedList = counts.ToList();
        sortedList.Sort((pair1, pair2) =>
        {
            int res = pair1.Value.CompareTo(pair2.Value);
            // If frequencies are equal, sort by Key for deterministic result
            if (res == 0) return Comparer<T>.Default.Compare(pair1.Key, pair2.Key);
            return res;
        });

        return sortedList[k - 1].Key;
    }
}
#pragma warning restore CS8714