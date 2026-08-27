Missing Letters to be a Pangram

```cs
// Given a sentence, find which letters of the alphabet are missing to make it a pangram.
// Case-insensitive, non-letter characters ignored.
// Returns the missing letters in alphabetical order (empty string if already a pangram).

public class MissingLettersToBePangram
{
    // Approach 1: HashSet, then filter the alphabet
    public string FindMissingHashSet(string sentence)
    {
        var seen = new HashSet<char>();
        foreach (var c in sentence.ToLowerInvariant())
        {
            if (char.IsLetter(c))
                seen.Add(c);
        }

        var sb = new StringBuilder();
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            if (!seen.Contains(letter))
                sb.Append(letter);
        }
        return sb.ToString();
    }

    // Approach 2: bitmask, then extract missing bits
    public string FindMissingBitmask(string sentence)
    {
        int mask = 0;
        foreach (var raw in sentence)
        {
            if (!char.IsLetter(raw)) continue;
            char c = char.ToLowerInvariant(raw);
            mask |= 1 << (c - 'a');
        }

        var sb = new StringBuilder();
        for (int i = 0; i < 26; i++)
        {
            // bit not set means letter is missing
            if ((mask & (1 << i)) == 0)
                sb.Append((char)('a' + i));
        }
        return sb.ToString();
    }
}```