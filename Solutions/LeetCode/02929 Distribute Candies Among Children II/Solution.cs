// Distribute Candies Among Children II
namespace CompetitiveProgramming.LeetCode.DistributeCandiesAmongChildrenII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

public class Solution
{
    public long DistributeCandies(int n, int limit)
    {
        if (limit * 3 < n)
            return 0;
        long result = 0;
        for (int i = Math.Max(0, n - 2 * limit); i <= n && i <= limit; i++)
        {
            int sm = n - i;
            result += (Math.Min(limit, sm) - (sm - Math.Min(limit, sm)) + 1);
        }
        return result;
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Distribute Candies Among Children II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
	}
}