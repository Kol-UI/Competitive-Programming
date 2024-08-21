// Longest Harmonious Subsequence

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestHarmoniousSubsequence
{
    public class Solution
    {
        public int FindLHS(int[] nums)
        {
            var frequencyMap = BuildFrequencyMap(nums);
            return CalculateLongestHarmoniousSubsequence(frequencyMap);
        }

        private Dictionary<int, int> BuildFrequencyMap(int[] nums)
        {
            var frequencyMap = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            return frequencyMap;
        }

        private int CalculateLongestHarmoniousSubsequence(Dictionary<int, int> frequencyMap)
        {
            int maxLength = 0;

            foreach (var keyValuePair in frequencyMap)
            {
                int currentNumber = keyValuePair.Key;
                int currentCount = keyValuePair.Value;

                if (frequencyMap.TryGetValue(currentNumber + 1, out int nextCount))
                {
                    maxLength = Math.Max(maxLength, currentCount + nextCount);
                }
            }

            return maxLength;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Harmonious Subsequence");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}