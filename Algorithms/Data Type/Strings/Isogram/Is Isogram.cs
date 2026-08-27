namespace CompetitiveProgramming.Algorithms;
// An isogram is a word with no repeating letters (case-insensitive).
// Empty string and single-letter words count as isograms.
public class IsIsogram
{
    // Approach 1: HashSet
    public bool CheckWithHashSet(string word)
    {
        var seen = new HashSet<char>();
        foreach (var c in word.ToLowerInvariant())
        {
            if (!seen.Add(c))
                return false;
        }
        return true;
    }

    // Approach 2: Bitmask
    public bool CheckWithBitmask(string word)
    {
        int mask = 0;
        foreach (var c in word.ToLowerInvariant())
        {
            int bit = 1 << (c - 'a');
            if ((mask & bit) != 0)
                return false;
            mask |= bit;
        }
        return true;
    }
}