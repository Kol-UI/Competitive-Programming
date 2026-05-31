namespace CompetitiveProgramming.Algorithms;
public class SortByFrequency
{
    // Linq Approach
    // Sorts a Dictionary<string, int> by its frequency values
    public static List<string> SortByFrequencyLinq(Dictionary<string, int> wordCounts, bool descending = true)
    {
        ArgumentNullException.ThrowIfNull(wordCounts);

        // Convert dictionary to a sortable query
        var query = wordCounts.AsEnumerable();

        if (descending)
        {
            return query.OrderByDescending(pair => pair.Value) // Most frequent first
                        .ThenBy(pair => pair.Key)               // Alphabetical stability
                        .Select(pair => pair.Key)
                        .ToList();
        }

        return query.OrderBy(pair => pair.Value)                // Least frequent first
                    .ThenBy(pair => pair.Key)                   // Alphabetical stability
                    .Select(pair => pair.Key)
                    .ToList();
    }

    // Manual Approach
    public static List<string> SortByFrequencyManual(Dictionary<string, int> wordCounts, bool descending = true)
    {
        ArgumentNullException.ThrowIfNull(wordCounts);

        // Step 1: Copy dictionary entries to a list for in-place sorting
        List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>(wordCounts);

        // Step 2: Perform the sort using a comparison delegate
        list.Sort((pair1, pair2) =>
        {
            // Compare frequencies
            int result = descending 
                ? pair2.Value.CompareTo(pair1.Value) 
                : pair1.Value.CompareTo(pair2.Value);

            // If frequencies are equal, use alphabetical order (Tie-breaker)
            if (result == 0)
            {
                return string.Compare(pair1.Key, pair2.Key, StringComparison.OrdinalIgnoreCase);
            }

            return result;
        });

        // Step 3: Extract only the words (keys) into the final list
        List<string> sortedWords = new List<string>(list.Count);
        foreach (var pair in list)
        {
            sortedWords.Add(pair.Key);
        }

        return sortedWords;
    }
}