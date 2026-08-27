namespace CompetitiveProgramming.Algorithms;
// Check if a sentence contains every letter of the English alphabet at least once.
// Sentence has only lowercase letters and spaces.
// Example: "thequickbrownfoxjumpsoverthelazydog" -> true

public class IsPangram
{
    // Approach 1: HashSet
    public bool CheckHashSet(string sentence)
    {
        var seen = new HashSet<char>();
        foreach (var c in sentence)
        {
            if (c != ' ')
                seen.Add(c);
        }
        return seen.Count == 26;
    }

    // Approach 2: bool array, one slot per letter
    public bool CheckBoolArray(string sentence)
    {
        var seenLetters = new bool[26];
        int count = 0;

        foreach (var c in sentence)
        {
            if (c == ' ') continue;
            int index = c - 'a';
            if (!seenLetters[index])
            {
                seenLetters[index] = true;
                count++;
                if (count == 26) return true;
            }
        }
        return count == 26;
    }

    // Approach 3: bitmask (int as a set of 26 bits)
    public bool CheckBitmask(string sentence)
    {
        int mask = 0;
        foreach (var c in sentence)
        {
            if (c == ' ') continue;
            mask |= 1 << (c - 'a');
        }
        // 26 bits set means all letters present
        return mask == (1 << 26) - 1;
    }
}