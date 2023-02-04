using System;

namespace CompetitiveProgramming.LeetCode.ConcatenatedWords
{
    public class Solution
    {
        // Given an array of strings words (without duplicates), return all the concatenated words in the given list of words.
        // A concatenated word is defined as a string that is comprised entirely of at least two shorter words in the given array.

        // Example 1:

        // Input: words = ["cat","cats","catsdogcats","dog","dogcatsdog","hippopotamuses","rat","ratcatdogcat"]
        // Output: ["catsdogcats","dogcatsdog","ratcatdogcat"]
        // Explanation: "catsdogcats" can be concatenated by "cats", "dog" and "cats"; 
        // "dogcatsdog" can be concatenated by "dog", "cats" and "dog"; 
        // "ratcatdogcat" can be concatenated by "rat", "cat", "dog" and "cat".
        
        // Example 2:

        // Input: words = ["cat","dog","catdog"]
        // Output: ["catdog"]



        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            var res = new List<string>();
            var set = new HashSet<string>();
            foreach(var word in words)
            {
                set.Add(word);
            }
                
            foreach(var word in words) 
            {
                if (DFS(words, word, set, 0, 0)) 
                {
                    res.Add(word);
                }
            }
            return res;
        }

        public bool DFS(string[] words, string word, HashSet<string> set, int start, int wordCount)
        {
            if (start >= word.Length)
            {
                return wordCount > 1;
            }

            for(int i = start; i < word.Length; i++)
            {
                if (set.Contains(word.Substring(start, i-start+1)) && DFS(words, word, set, i+1, wordCount+1)) {
                    return true;
                }
            }

            return false;
        }


    }
}