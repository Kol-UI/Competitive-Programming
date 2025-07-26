// Check if Any Element Has Prime Frequency
namespace CompetitiveProgramming.LeetCode.CheckifAnyElementHasPrimeFrequency;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckPrimeFrequency(int[] nums)
    {
        var amount = new int[101];

        foreach (var i in nums)
        {
            amount[i]++;
        }

        foreach (var a in amount)
        {
            if (a == 0 || a == 1)
                continue;
            if (a == 2)
                return true;
            if (a % 2 == 0)
                continue;
            var max = (int)Math.Sqrt(a);
            var IsPrime = true;

            for (var i = 3; i <= max; i++)
            {
                if (a % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
                return true;
        }

        return false;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Any Element Has Prime Frequency");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}