Longest Isogrammatic Substring

```cs
// Finds the longest substring that contains no repeating letters (case-insensitive).
// Returns the substring itself, not just its length.
public class LongestIsogrammaticSubstring
{
    // Approach 1: sliding window with HashSet
    public string FindWithHashSet(string word)
    {
        var lower = word.ToLowerInvariant();
        var seen = new HashSet<char>();
        int start = 0;
        int bestStart = 0, bestLen = 0;

        for (int end = 0; end < lower.Length; end++)
        {
            // shrink window until no duplicate
            while (seen.Contains(lower[end]))
            {
                seen.Remove(lower[start]);
                start++;
            }

            seen.Add(lower[end]);

            if (end - start + 1 > bestLen)
            {
                bestLen = end - start + 1;
                bestStart = start;
            }
        }

        return word.Substring(bestStart, bestLen);
    }

    // Approach 2: sliding window with last-seen index map
    public string FindWithLastSeenIndex(string word)
    {
        var lower = word.ToLowerInvariant();
        var lastSeen = new Dictionary<char, int>();
        int start = 0;
        int bestStart = 0, bestLen = 0;

        for (int end = 0; end < lower.Length; end++)
        {
            char c = lower[end];

            // jump window start past the previous occurrence
            if (lastSeen.TryGetValue(c, out int prevIndex) && prevIndex >= start)
                start = prevIndex + 1;

            lastSeen[c] = end;

            if (end - start + 1 > bestLen)
            {
                bestLen = end - start + 1;
                bestStart = start;
            }
        }

        return word.Substring(bestStart, bestLen);
    }
}```