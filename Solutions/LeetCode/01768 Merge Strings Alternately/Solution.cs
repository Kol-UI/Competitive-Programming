// Merge Strings Alternately

/*
You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.

 

Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r

Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s

Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d
*/
using System;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MergeStringsAlternately
{
    public class Solution
    {
        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            int j = 0;
            while (i < word1.Length && j < word2.Length)
            {
                sb.Append(word1[i++]);
                sb.Append(word2[j++]);
            }
            while (i < word1.Length)
            {
                sb.Append(word1[i++]);
            }
            while (j < word2.Length)
            {
                sb.Append(word2[j++]);
            }
            return sb.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            string Case1_1768 = Solution.MergeAlternately("abc", "pqr");

            // Case 2
            string Case2_1768 = Solution.MergeAlternately("ab", "pqrs");

            // Case 3
            string Case3_1768 = Solution.MergeAlternately("abcd", "pq");

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_1768, "apbqcr"),
                ResultTester.CheckResult<string>(Case2_1768, "apbqrs"),
                ResultTester.CheckResult<string>(Case3_1768, "apbqcd")
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Strinngs Alternately");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}