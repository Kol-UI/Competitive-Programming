// K-th Smallest in Lexicographical Order

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KthSmallestinLexicographicalOrder
{
    public class Solution
    {
        public int FindKthNumber(int n, int k)
        {
            int current = 1;
            k--;

            while (k > 0)
            {
                long steps = CalculateSteps(n, current, current + 1);

                if (steps <= k)
                {
                    current++;
                    k -= (int)steps;
                }
                else
                {
                    current *= 10;
                    k--;
                }
            }

            return current;
        }

        private long CalculateSteps(int n, long first, long last)
        {
            long steps = 0;
            while (first <= n)
            {
                steps += Math.Min(n + 1, last) - first;
                first *= 10;
                last *= 10;
            }
            return steps;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.FindKthNumber(13, 2), 10),
                ResultTester.CheckResult<int>(solution.FindKthNumber(1, 1), 1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("K-th Smallest in Lexicographical Order");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}