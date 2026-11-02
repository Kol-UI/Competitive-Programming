// Maximum Product Pair With Target Sum
namespace CompetitiveProgramming.LeetCode.MaximumProductPairWithTargetSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] MaxProductPair(int[] nums, int target) {
        var result = new int[2]{-1, -1};
        var maxProduct = int.MinValue;
        var dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
          var n = nums[i];
          dic[n] = i;
          var diff = target - n;
          if(diff != n && dic.TryGetValue(diff, out var i2))
          {
            var tmpProduct = diff * n;
            if(tmpProduct > maxProduct)
              (result[0], result[1], maxProduct) = diff > n ? (i2, i, tmpProduct) : (i, i2, tmpProduct);
          }
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
            ResultTester.CheckResult<int[]>(solution.MaxProductPair([1,2,3,4], 5), [2,1]),
            ResultTester.CheckResult<int[]>(solution.MaxProductPair([-3,-1,4,2], 1), [3,1]),
            ResultTester.CheckResult<int[]>(solution.MaxProductPair([3,3,5], 6), [-1,-1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Product Pair With Target Sum");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}