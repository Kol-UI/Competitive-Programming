namespace CompetitiveProgramming.Algorithms;
// Find the smallest window in a string that contains all 26 letters of the alphabet.
// Case-insensitive. Returns empty string if no such window exists (e.g. missing letters entirely).

public class SmallestWindowAllAlphabet
{
    // Approach 1: sliding window with frequency array + distinct counter
    public string FindSmallestWindow(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";

        var text = s.ToLowerInvariant();
        var freq = new int[26];
        int distinctCount = 0;
        int bestLen = int.MaxValue;
        int bestStart = -1;

        int left = 0;
        for (int right = 0; right < text.Length; right++)
        {
            char c = text[right];
            if (!char.IsLetter(c)) continue;

            int idx = c - 'a';
            if (freq[idx] == 0) distinctCount++;
            freq[idx]++;

            // shrink from the left while window still has all 26 letters
            while (distinctCount == 26)
            {
                int windowLen = right - left + 1;
                if (windowLen < bestLen)
                {
                    bestLen = windowLen;
                    bestStart = left;
                }

                char leftChar = text[left];
                if (char.IsLetter(leftChar))
                {
                    int leftIdx = leftChar - 'a';
                    freq[leftIdx]--;
                    if (freq[leftIdx] == 0) distinctCount--;
                }
                left++;
            }
        }

        return bestStart == -1 ? "" : s.Substring(bestStart, bestLen);
    }

    // Approach 2: sliding window using a Dictionary instead of a fixed array
    public string FindSmallestWindowDictionary(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";

        var text = s.ToLowerInvariant();
        var freq = new Dictionary<char, int>();
        int bestLen = int.MaxValue;
        int bestStart = -1;

        int left = 0;
        for (int right = 0; right < text.Length; right++)
        {
            char c = text[right];
            if (!char.IsLetter(c)) continue;

            freq[c] = freq.GetValueOrDefault(c, 0) + 1;

            while (freq.Count == 26)
            {
                int windowLen = right - left + 1;
                if (windowLen < bestLen)
                {
                    bestLen = windowLen;
                    bestStart = left;
                }

                char leftChar = text[left];
                if (char.IsLetter(leftChar))
                {
                    freq[leftChar]--;
                    if (freq[leftChar] == 0) freq.Remove(leftChar);
                }
                left++;
            }
        }

        return bestStart == -1 ? "" : s.Substring(bestStart, bestLen);
    }
}