Returns the least frequent element.
```cs
public class LeastFrequentElement
{
    // Linq Approach
    public static T GetLeastFrequentLinq<T>(IEnumerable<T> list)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));

        var leastFrequentGroup = list
            .GroupBy(x => x)
            .OrderBy(g => g.Count()) // sort
            .ThenBy(g => g.Key)      // alphabetical in case of equality
            .FirstOrDefault();

        if (leastFrequentGroup == null)
            throw new InvalidOperationException("List is empty.");

        return leastFrequentGroup.Key;
    }

    // Manual Approach
    public static T GetLeastFrequentManual<T>(IEnumerable<T> list)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));

        var counts = new Dictionary<T, int>();
        foreach (var item in list)
        {
            counts[item] = counts.ContainsKey(item) ? counts[item] + 1 : 1;
        }

        if (counts.Count == 0) 
            throw new InvalidOperationException("La collection est vide.");

        T leastFrequent = default;
        int minCount = int.MaxValue;

        foreach (var kvp in counts)
        {
            if (kvp.Value < minCount)
            {
                minCount = kvp.Value;
                leastFrequent = kvp.Key;
            }
        }

        return leastFrequent;
    }
}```