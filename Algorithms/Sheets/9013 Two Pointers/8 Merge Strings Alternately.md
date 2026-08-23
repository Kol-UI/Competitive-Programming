Merge Strings Alternately :

You are given two strings, word1 and word2.

Construct a new string by merging them in alternating order, starting with word1 — take one character from word1, then one from word2, and repeat this process.

If one string is longer than the other, append the remaining characters from the longer string to the end of the merged result.

Return the final merged string.


Example 1:

Input: word1 = "abc", word2 = "xyz"

Output: "axbycz"


Example 2:

Input: word1 = "ab", word2 = "abbxxc"

Output: "aabbbxxc"



```cs

// Brute Force Approch
public class MergeStringsAlternatelyBruteForce()
{
    public string MergeAlternately(string word1, string word2)
    {
        if (string.IsNullOrEmpty(word1)) return word2;
        if (string.IsNullOrEmpty(word2)) return word1;

        StringBuilder result = new StringBuilder();
        int maxLen = Math.Max(word1.Length, word2.Length);

        for (int i = 0; i < maxLen; i++)
        {
            if (i < word1.Length) result.Append(word1[i]);
            if (i < word2.Length) result.Append(word2[i]);
        }

        return result.ToString();
    }
}

// Two Pointers Approch
public class MergeStringsAlternatelyTwoPointers
{
    public string MergeAlternately(string word1, string word2)
    {
        if (string.IsNullOrEmpty(word1)) return word2;
        if (string.IsNullOrEmpty(word2)) return word1;
        int i = 0, j = 0;
        StringBuilder result = new StringBuilder();

        /* abcde - xyz

            result :
            0: a 0: x / ax
            1: b 1: y / axby
            2: c 2: z / axbycz
            word1.Substring(3) = de (take what's left)
            "axbyczde"
        */

        while (i < word1.Length && j < word2.Length)
        {
            result.Append(word1[i]);
            result.Append(word2[j]);
            i++;
            j++;
        }

        result.Append(word1.Substring(i));
        result.Append(word2.Substring(j));

        return result.ToString();
    }
}

// Two Pointers II Approch
public class MergeStringsAlternatelyTwoPointersII
{
    public string MergeAlternately(string word1, string word2)
    {
        if (string.IsNullOrEmpty(word1)) return word2;
        if (string.IsNullOrEmpty(word2)) return word1;
        int len1 = word1.Length, len2 = word2.Length;
        int i = 0, j = 0;
        StringBuilder result = new StringBuilder();

        /* abcde - xyz

            result :
            0: a 0: x / ax
            1: b 1: y / axby
            2: c 2: z / axbycz
            3: d / axbyczd
            4: e / axbyczde
            "axbyczde"
        */

        while (i < len1 || j < len2)
        {
            if (i < len1)
            {
                result.Append(word1[i]);
            }
            if (j < len2)
            {
                result.Append(word2[j]);
            }
            i++;
            j++;
        }

        return result.ToString();
    }
}

public class MergeStringsAlternatelyOnePointer
{
    public string MergeAlternately(string word1, string word2)
    {
        if (string.IsNullOrEmpty(word1)) return word2;
        if (string.IsNullOrEmpty(word2)) return word1;
        int len1 = word1.Length, len2 = word2.Length;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < Math.Max(len1, len2); i++)
        {
            if (i < len1)
            {
                result.Append(word1[i]);
            }
            if (i < len2)
            {
                result.Append(word2[i]);
            }
        }

        return result.ToString();
    }
}
```