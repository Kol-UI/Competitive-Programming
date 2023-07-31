using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.VerifyinganAlienDictionary
{
    public class Solution
    {
        // In an alien language, surprisingly, they also use English lowercase letters, but possibly in a different order. The order of the alphabet is some permutation of lowercase letters.
        // Given a sequence of words written in the alien language, and the order of the alphabet, return true if and only if the given words are sorted lexicographically in this alien language.

        // Example 1:

        // Input: words = ["hello","leetcode"], order = "hlabcdefgijkmnopqrstuvwxyz"
        // Output: true
        // Explanation: As 'h' comes before 'l' in this language, then the sequence is sorted.

        // Example 2:

        // Input: words = ["word","world","row"], order = "worldabcefghijkmnpqstuvxyz"
        // Output: false
        // Explanation: As 'd' comes after 'l' in this language, then words[0] > words[1], hence the sequence is unsorted.

        // Example 3:

        // Input: words = ["apple","app"], order = "abcdefghijklmnopqrstuvwxyz"
        // Output: false
        // Explanation: The first three characters "app" match, and the second string is shorter (in size.) According to lexicographical rules "apple" > "app", because 'l' > '∅', where '∅' is defined as the blank character which is less than any other character
        public static bool IsAlienSorted(string[] words, string order)
        {
            var dict = new Dictionary<char, int>();

            for (int i=0; i<order.Length; i++)
            {
                dict.Add(order[i], i);
            }

            for (int j = 1; j < words.Length; j++)
            {
                var first = words[j-1];
                var second = words[j];

                if (first.StartsWith(second) && first.Length > second.Length )
                {
                    return false;
                }

                var min = Math.Min(first.Length, second.Length);

                for (int k = 0; k < min; k++)
                {
                    var f = first[k];
                    var s = second[k];
                
                    if (first[k] == second[k])
                    {
                        continue;
                    }

                    if (dict[first[k]] < dict[second[k]])
                    {
                        break;
                    }

                    if (dict[first[k]] > dict[second[k]])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

    public class Test
    {
        public static bool[] TestVerifyinganAlienDictionary()
        {
            string[] words1 = new string[] {"hello", "leetcode"};
            string order1 = "hlabcdefgijkmnopqrstuvwxyz";
            bool output1 = true;

            string[] words2 = new string[] {"word", "world", "row"};
            string order2 = "worldabcefghijkmnpqstuvxyz";
            bool output2 = false;

            string[] words3 = new string[] {"apple", "app"};
            string order3 = "abcdefghijklmnopqrstuvwxyz";
            bool output3 = false;


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsAlienSorted(words1, order1), output1),
                ResultTester.CheckResult<bool>(Solution.IsAlienSorted(words2, order2), output2),
                ResultTester.CheckResult<bool>(Solution.IsAlienSorted(words3, order3), output3)
            };

            return results;
        }
    }
}