Pangram vs Isogram

```cs
// Classify a text as a Pangram (contains all 26 letters), an Isogram (no letter repeats),
// both (a "perfect pangram", exactly 26 distinct letters), or neither.
// Case-insensitive, non-letter characters (spaces, punctuation) are ignored.

public enum WordClassification
{
    Neither,
    Pangram,
    Isogram,
    Both
}

public class PangramIsogramClassifier
{
    // Approach 1: two separate passes, using HashSet + Dictionary
    public WordClassification Classify(string text)
    {
        text = text.ToLowerInvariant();

        var counts = new Dictionary<char, int>();
        foreach (var c in text)
        {
            if (!char.IsLetter(c)) continue;
            counts[c] = counts.GetValueOrDefault(c, 0) + 1;
        }

        bool isPangram = counts.Count == 26;
        bool isIsogram = counts.Values.All(v => v == 1);

        return Combine(isPangram, isIsogram);
    }

    // Approach 2: single pass, bitmask for letters seen + a flag for duplicates
    public WordClassification ClassifyBitmask(string text)
    {
        int mask = 0;
        bool hasDuplicate = false;

        foreach (var raw in text)
        {
            if (!char.IsLetter(raw)) continue;
            char c = char.ToLowerInvariant(raw);
            int bit = 1 << (c - 'a');

            if ((mask & bit) != 0)
                hasDuplicate = true;

            mask |= bit;
        }

        bool isPangram = mask == (1 << 26) - 1;
        bool isIsogram = !hasDuplicate;

        return Combine(isPangram, isIsogram);
    }

    private static WordClassification Combine(bool isPangram, bool isIsogram)
    {
        if (isPangram && isIsogram) return WordClassification.Both;
        if (isPangram) return WordClassification.Pangram;
        if (isIsogram) return WordClassification.Isogram;
        return WordClassification.Neither;
    }
}```