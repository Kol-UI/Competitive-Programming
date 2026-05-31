namespace CompetitiveProgramming.Algorithms;
public class UniqueCharacters
{
    public static List<int> FindUniquePositions(char[] arr)
    {
        // Dictionary to store: <Character, (Number of occurrences, Index)>
        Dictionary<char, (int count, int index)> tracker = new();

        for (int i = 0; i < arr.Length; i++)
        {
            if (tracker.ContainsKey(arr[i]))
            {
                // The counter is incremented if already seen
                var entry = tracker[arr[i]];
                tracker[arr[i]] = (entry.count + 1, entry.index);
            }
            else
            {
                // First step: we record the index
                tracker[arr[i]] = (1, i);
            }
        }

        // We only return the indices of characters whose count is exactly 1
        return tracker.Values
            .Where(x => x.count == 1)
            .Select(x => x.index)
            .OrderBy(index => index) // Keep order
            .ToList();
    }
}