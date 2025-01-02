// Count Vowel Strings in Ranges

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountVowelStringsinRanges
{
    public class Solution
    {
        public int[] VowelStrings(string[] words, int[][] queries)
        {
            int n = words.Length;
            int[] prefixSum = new int[n + 1];

            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < n; i++)
            {
                if (vowels.Contains(words[i][0]) && vowels.Contains(words[i][words[i].Length - 1]))
                {
                    prefixSum[i + 1] = prefixSum[i] + 1;
                }
                else
                {
                    prefixSum[i + 1] = prefixSum[i];
                }
            }

            int[] result = new int[queries.Length];
            
            for (int i = 0; i < queries.Length; i++)
            {
                int l = queries[i][0], r = queries[i][1];
                result[i] = prefixSum[r + 1] - prefixSum[l];
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            int[][] firstArray = new int[][]
            {
                new int[] { 0, 2 },
                new int[] { 1, 4 },
                new int[] { 1, 1 }
            };

            int[][] secondArray = new int[][]
            {
                new int[] { 0, 2 },
                new int[] { 0, 1 },
                new int[] { 2, 2 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(solution.VowelStrings(new string[] {"aba","bcb","ece","aa","e"}, firstArray), new int[]{2,3,0}),
                ResultTester.CheckResult<int[]>(solution.VowelStrings(new string[] {"a","e","i"}, secondArray), new int[]{3,2,1})
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Vowel Strings in Ranges");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}