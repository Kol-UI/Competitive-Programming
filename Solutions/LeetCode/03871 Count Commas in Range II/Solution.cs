// Count Commas in Range II
namespace CompetitiveProgramming.LeetCode.CountCommasinRangeII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long CountCommas(long n)
    {
        int digs = 0;
        long current = n;
        while(current > 0)
        {
            current /= 10;
            digs++;
        }

        if(digs < 4)
            return 0;

        long comms = (digs-1)/3;
        long low = (long)Math.Pow(10, comms*3);
        long result = (long)(n-low+1)*comms;
        comms--;

        while(comms > 0)
        {
            long high = (long)Math.Pow(10, (comms+1)*3);
            low = (long)Math.Pow(10, comms*3);
            long currentGap = (long)(high-low)*comms;
            result += currentGap;

            comms--;
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.CountCommas(1002), 3),
            ResultTester.CheckResult<long>(solution.CountCommas(998), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Commas in Range II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}