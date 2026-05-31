Returns the K-th most frequent element.
```cs
public class KthMostFrequent
{
    // Linq Approach
    public static T GetKthMostFrequentLinq<T>(IEnumerable<T> list, int k)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        if (k <= 0) throw new ArgumentOutOfRangeException(nameof(k), "K must be supperior than 0.");

        var result = list
            .GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .Select(g => g.Key)
            .Skip(k - 1) // Skip (k-1) most frequents
            .FirstOrDefault();

        // if result null or list doesn't have enough unique elements
        if (result == null && list.GroupBy(x => x).Count() < k)
            throw new InvalidOperationException($"There is not enough unique elements in order to find the {k}th element.");

        return result;
    }

    // Manual Approach
    public static T GetKthMostFrequentManual<T>(IEnumerable<T> list, int k)
    {
        var counts = new Dictionary<T, int>();
        foreach (var item in list)
        {
            counts[item] = counts.ContainsKey(item) ? counts[item] + 1 : 1;
        }

        if (counts.Count < k)
            throw new InvalidOperationException("There is not enough unique elements.");

        return counts.OrderByDescending(x => x.Value)
                    .ElementAt(k - 1)
                    .Key;
    }
}```