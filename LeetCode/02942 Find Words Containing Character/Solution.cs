// Find Words Containing Character

/*
You are given a 0-indexed array of strings words and a character x.

Return an array of indices representing the words that contain the character x.

Note that the returned array may be in any order.

 

Example 1:

Input: words = ["leet","code"], x = "e"
Output: [0,1]
Explanation: "e" occurs in both words: "leet", and "code". Hence, we return indices 0 and 1.

Example 2:

Input: words = ["abc","bcd","aaaa","cbc"], x = "a"
Output: [0,2]
Explanation: "a" occurs in "abc", and "aaaa". Hence, we return indices 0 and 2.

Example 3:

Input: words = ["abc","bcd","aaaa","cbc"], x = "z"
Output: []
Explanation: "z" does not occur in any of the words. Hence, we return an empty array.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindWordsContainingCharacter
{
    public class Solution
    {
        public static IList<int> FindWordsContaining(string[] words, char x)
        {
            var result = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].IndexOf(x) > -1) 
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string[] words1 = {"leet","code"};
            char x1 = 'e';
            string[] words2 = {"abc","bcd","aaaa","cbc"};
            char x2 = 'a';
            string[] words3 = {"abc","bcd","aaaa","cbc"};
            char x3 = 'z';
            IList<int> expected1 = new List<int> { 0, 1 };
            IList<int> expected2 = new List<int> { 0, 2 };
            IList<int> expected3 = Array.Empty<int>();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.FindWordsContaining(words1, x1), expected1),
                ResultTester.CheckResult<IList<int>>(Solution.FindWordsContaining(words2, x2), expected2),
                ResultTester.CheckResult<IList<int>>(Solution.FindWordsContaining(words3, x3), expected3),
            };
            return results;
        }
    }
}