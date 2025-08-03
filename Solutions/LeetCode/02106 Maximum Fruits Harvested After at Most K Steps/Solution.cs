// Maximum Fruits Harvested After at Most K Steps
namespace CompetitiveProgramming.LeetCode.MaximumFruitsHarvestedAfteratMostKSteps;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxTotalFruits(int[][] fruits, int startPos, int k)
    {
            var left = 0;
            var right = fruits.Length;
            var target = startPos - k;
            var sum = 0;
            var result = 0;

            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (fruits[mid][0] >= target)
                    right = mid;
                else
                    left = mid + 1;
            }

            for (right = left; right < fruits.Length && fruits[right][0] <= startPos + k; right++)
            {
                sum += fruits[right][1];

                while ((fruits[right][0] * 2 - fruits[left][0] - startPos > k) && (fruits[right][0] - fruits[left][0] * 2 + startPos > k))
                {
                    sum -= fruits[left++][1];
                }

                result = Math.Max(result, sum);
            }

            return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Fruits Harvested After at Most K Steps");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}