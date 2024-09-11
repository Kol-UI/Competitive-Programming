// Minimum Bit Flips to Convert Number

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumBitFlipstoConvertNumber
{
    public class Solution
    {
        public int MinBitFlips(int start, int goal)
        {
            int xorResult = GetXorResult(start, goal);
            int bitFlipCount = CountSetBitsToOne(xorResult);
            return bitFlipCount;
        }

        private static int GetXorResult(int start, int goal)
        {
            return start ^ goal;
        }
        
        private static int CountSetBitsToOne(int xorResult)
        {
            int count = 0;
            int isDifferent = 1;
            int notDifferent = 0;
            while (xorResult > notDifferent)
            {
                count += xorResult & isDifferent;
                xorResult >>= isDifferent;
            }
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new Solution();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MinBitFlips(10, 7), 3),
                ResultTester.CheckResult<int>(solution.MinBitFlips(3, 4), 3),
                ResultTester.CheckResult<int>(solution.MinBitFlips(2, 2), 0),
                ResultTester.CheckResult<int>(solution.MinBitFlips(4, 2), 2),
                ResultTester.CheckResult<int>(solution.MinBitFlips(2, 4), 2),
                ResultTester.CheckResult<int>(solution.MinBitFlips(4, 4), 0),
                ResultTester.CheckResult<int>(solution.MinBitFlips(5, 2), 3),
                ResultTester.CheckResult<int>(solution.MinBitFlips(2, 5), 3),
                ResultTester.CheckResult<int>(solution.MinBitFlips(4, 5), 1),
                ResultTester.CheckResult<int>(solution.MinBitFlips(5, 4), 1),
                ResultTester.CheckResult<int>(solution.MinBitFlips(3, 5), 2),
                ResultTester.CheckResult<int>(solution.MinBitFlips(5, 3), 2),
                ResultTester.CheckResult<int>(solution.MinBitFlips(4, 3), 3),
                ResultTester.CheckResult<int>(solution.MinBitFlips(6, 6), 0),
                ResultTester.CheckResult<int>(solution.MinBitFlips(2, 6), 1),
                ResultTester.CheckResult<int>(solution.MinBitFlips(3, 6), 2),
                ResultTester.CheckResult<int>(solution.MinBitFlips(4, 6), 1),
                ResultTester.CheckResult<int>(solution.MinBitFlips(5, 6), 2),
                ResultTester.CheckResult<int>(solution.MinBitFlips(6, 2), 1),
                ResultTester.CheckResult<int>(solution.MinBitFlips(6, 3), 2),
                ResultTester.CheckResult<int>(solution.MinBitFlips(6, 4), 1),
                ResultTester.CheckResult<int>(solution.MinBitFlips(6, 5), 2),
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Bit Flips to Convert Number");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}