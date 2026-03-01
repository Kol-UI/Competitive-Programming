// Binary Gap
namespace CompetitiveProgramming.LeetCode.BinaryGap;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int BinaryGap(int n)
    {
        int tempN = 0, tempDist = 0, maxDist = 0;
        while (n != 0)
        {
            tempN = (n & 1);
            if (tempN == 1)
            {
                if (tempDist > maxDist)
                {
                    maxDist = tempDist;
                }
                tempDist = 1;
            }
            else
            {
                if (tempDist != 0)
                {
                    tempDist++;
                }
            }
            n >>= 1;
        }
        return maxDist;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.BinaryGap(22), 2),
            ResultTester.CheckResult<int>(solution.BinaryGap(8), 0),
            ResultTester.CheckResult<int>(solution.BinaryGap(5), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Binary Gap");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}