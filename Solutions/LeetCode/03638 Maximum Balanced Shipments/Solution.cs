// Maximum Balanced Shipments
namespace CompetitiveProgramming.LeetCode.MaximumBalancedShipments;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxBalancedShipments(int[] weight)
    {
        var length = weight.Length;
        var result = 0;
        var left = 0;

        while (left < length)
        {
            var max = weight[left];
            var right = left + 1;

            while (right < length)
            {
                max = Math.Max(max, weight[right]);
                if (weight[right] < max)
                {
                    result++;
                    left = right + 1;
                    break;
                }
                right++;
            }

            if (right == length) break;
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Intercepted Inputs");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}