First Recurring Character

```cs
// Finds the first character whose second occurrence appears earliest
// when scanning the string left to right. Returns null if no character repeats.
public class FirstRecurringCharacter
{
    // Approach 1: HashSet
    public char? FindWithHashSet(string word)
    {
        var seen = new HashSet<char>();

        foreach (var c in word)
        {
            if (!seen.Add(c))
                return c;
        }

        return null;
    }

    // Approach 2: brute force
    public char? FindWithBruteForce(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (word[j] == word[i])
                    return word[i];
            }
        }

        return null;
    }
}```