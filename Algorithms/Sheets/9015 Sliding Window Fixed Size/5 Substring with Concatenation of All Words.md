Substring with Concatenation of All Words


You are given a string s and an array of strings words. All the strings of words are of the same length.

A concatenated string is a string that exactly contains all the strings of any permutation of words concatenated.

For example, if words = ["ab","cd","ef"], then "abcdef", "abefcd", "cdabef", "cdefab", "efabcd", and "efcdab" are all concatenated strings. "acdbef" is not a concatenated string because it is not the concatenation of any permutation of words.
Return an array of the starting indices of all the concatenated substrings in s. You can return the answer in any order. 

Example 1:
Input: s = "barfoothefoobarman", words = ["foo","bar"]

Output: [0,9]

Explanation:

The substring starting at 0 is "barfoo". It is the concatenation of ["bar","foo"] which is a permutation of words.

The substring starting at 9 is "foobar". It is the concatenation of ["foo","bar"] which is a permutation of words.

Example 2:
Input: s = "wordgoodgoodgoodbestword", words = ["word","good","best","word"]

Output: []

Explanation:

There is no concatenated substring.

Example 3:
Input: s = "barfoofoobarthefoobarman", words = ["bar","foo","the"]

Output: [6,9,12]

Explanation:

The substring starting at 6 is "foobarthe". It is the concatenation of ["foo","bar","the"].

The substring starting at 9 is "barthefoo". It is the concatenation of ["bar","the","foo"].

The substring starting at 12 is "thefoobar". It is the concatenation of ["the","foo","bar"]. 


```cs
// Slinding Window Hash Approch
public class SubstringwithConcatenationofAllWords_SlindingWindowHash
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        List<int> result = [];
        Dictionary<string, int> wordHash = []; // frequency
        int wordLength = words[0].Length;
        int wordsCount = words.Length;
        if (string.IsNullOrEmpty(s) || wordsCount == 0 || wordLength == 0) return result;

        foreach (var w in words)
        {
            wordHash[w] = wordHash.ContainsKey(w) ? wordHash[w] + 1 : 1;
        }

        // iterate through all possible starting offsets (0 to wordLength - 1)
        for (int i = 0; i < wordLength; i++)
        {
            int left = i;
            int count = 0;
            Dictionary<string, int> seen = [];

            // sliding word by word
            for (int right = left; right <= s.Length - wordLength; right += wordLength)
            {
                string word = s.Substring(right, wordLength);
                if (wordHash.ContainsKey(word)) 
                {
                    seen[word] = seen.ContainsKey(word) ? seen[word] + 1 : 1;
                    count++;
                    // if we have more occurrences of 'word' than needed, shrink the window from the left until it's valid again
                    while (seen[word] > wordHash[word]) 
                    {
                        string leftWord = s.Substring(left, wordLength);
                        seen[leftWord]--;
                        count--;
                        left += wordLength;
                    }
                    // if the number of matched words equals our target count, we found a match
                    if (count == words.Length) 
                    {
                        result.Add(left);
                    }
                } 
                else 
                {
                    // not a target word, reset the window and jump to the next position
                    left = right + wordLength;
                    seen.Clear();
                    count = 0;
                }
            }
        }

        return result;
    }
}
```
