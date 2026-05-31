namespace CompetitiveProgramming.Algorithms;
#pragma warning disable CS8600
#pragma warning disable CS8603
#pragma warning disable CS8714
public class MostFrequentElement
{
    // Linq Approach
    public static T GetMostFrequentLinq<T>(IEnumerable<T> list)
    {
        if (list == null) 
            throw new ArgumentNullException(nameof(list));

        var mostFrequentGroup = list
            .GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .FirstOrDefault();

        if (mostFrequentGroup == null)
            throw new InvalidOperationException("List in empty");

        return mostFrequentGroup.Key;
    }

    // Manual Approach
    public static T GetMostFrequentManual<T>(IEnumerable<T> list)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));

        var counts = new Dictionary<T, int>();
        T mostFrequent = default;
        int maxCount = 0;

        foreach (T item in list)
        {
            if (item == null) continue;

            // update count
            int count = counts.ContainsKey(item) ? ++counts[item] : counts[item] = 1;

            // check record
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequent = item;
            }
        }

        if (maxCount == 0) throw new InvalidOperationException("No Element Found.");
        
        return mostFrequent;
    }
}
#pragma warning restore CS8600
#pragma warning restore CS8603
#pragma warning restore CS8714