// Minimum Cuts to Divide a Circle


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumCutstoDivideaCircle
{
    public class Solution
    {
        public static int NumberOfCuts(int n)
        {
            if(n % 2 == 0)
            {
                return n / 2;
            }
            else if(n == 1)
            {
                return 0;
            }

            return n;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumberOfCuts(4), 2),
                ResultTester.CheckResult<int>(Solution.NumberOfCuts(3), 3),
            };
            return results;
        }
    }
}