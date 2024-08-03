// Least Number of Unique Integers after K Removals


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LeastNumberofUniqueIntegersafterKRemovals
{
    public class Solution
    {
        public static int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (!counts.ContainsKey(num))
                {
                    counts[num] = 0;
                }
                counts[num]++;
            }

            var sortedCounts = counts.OrderBy(pair => pair.Value);

            foreach (var pair in sortedCounts)
            {
                if (k >= pair.Value)
                {
                    k -= pair.Value;
                    counts.Remove(pair.Key);
                }
                else
                {
                    break;
                }
            }

            return counts.Count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindLeastNumOfUniqueInts(new int[] {5,5,4}, 1), 1),
                ResultTester.CheckResult<int>(Solution.FindLeastNumOfUniqueInts(new int[] {4,3,1,1,3,3,2}, 3), 2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Least Number of Unique Integers after K Removals");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}