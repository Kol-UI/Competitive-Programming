// Relative Ranks

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RelativeRanks
{
    public class Solution
    {
        public static string[] FindRelativeRanks(int[] score)
        {
            var scores = GetSortedIndices(score);
            var result = new string[score.Length];
            for (int i = 0; i < score.Length; i++)
            {
                result[i] = FindRelativeRank(score[i], scores);
            }
            return result;
        }

        private static string FindRelativeRank(int score, Dictionary<int, int> values)
        {
            if (values[score] > 3)
            {
                return (values[score]).ToString();
            }
            if (values[score] == 1)
            {
                return "Gold Medal";
            }
            if (values[score] == 2)
            {
                return "Silver Medal";
            }
            return "Bronze Medal";
        }

        private static Dictionary<int, int> GetSortedIndices(int[] score)
        {
            var list = new List<int>(score);
            var result = new Dictionary<int, int>();
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(list[i], list.Count - i);
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string[]>(Solution.FindRelativeRanks(new int[]{5,4,3,2,1}), new string[]{"Gold Medal","Silver Medal","Bronze Medal","4","5"}),
                ResultTester.CheckResult<string[]>(Solution.FindRelativeRanks(new int[]{10,3,8,9,4}), new string[]{"Gold Medal","5","Bronze Medal","Silver Medal","4"}),
            };
            return results;
        }
    }
}