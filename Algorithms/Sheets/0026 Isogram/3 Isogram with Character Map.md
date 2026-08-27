Isogram with Character Map

```cs
// Checks if a word is an isogram by building a character frequency map first,
// then verifying no letter appears more than once.
public class IsogramWithCharacterMap
{
    // Approach 1: fixed-size array map (a-z only)
    public bool CheckWithArrayMap(string word)
    {
        var counts = new int[26];
        var lower = word.ToLowerInvariant();

        foreach (var c in lower)
            counts[c - 'a']++;

        foreach (var count in counts)
        {
            if (count > 1)
                return false;
        }

        return true;
    }

    // Approach 2: Dictionary map
    public bool CheckWithDictionaryMap(string word)
    {
        var map = new Dictionary<char, int>();
        var lower = word.ToLowerInvariant();

        foreach (var c in lower)
        {
            map[c] = map.GetValueOrDefault(c, 0) + 1;
        }

        foreach (var count in map.Values)
        {
            if (count > 1)
                return false;
        }

        return true;
    }
}```