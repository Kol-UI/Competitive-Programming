// Three Divisors


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ThreeDivisors
{
    public class Solution
    {
        public static bool IsThree(int n)
        {
            return Enumerable.Range(1, n + 1).Where(e => n % e == 0).Count() == 3;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsThree(2), false),
                ResultTester.CheckResult<bool>(Solution.IsThree(4), true),
            };
            return results;
        }
    }
}