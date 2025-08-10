// Tuple with Same Product

namespace CompetitiveProgramming.LeetCode.TuplewithSameProduct;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int TupleSameProduct(int[] nums)
    {
        Dictionary<int, int> countDic = new Dictionary<int, int>();
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int product = nums[i] * nums[j];
                if (countDic.ContainsKey(product))
                {
                    result += 8 * countDic[product];
                    countDic[product]++;
                }
                else
                {
                    countDic[product] = 1;
                }
            }
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution sol = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(sol.TupleSameProduct(new int[]{2,3,4,6}), 8),
            ResultTester.CheckResult<int>(sol.TupleSameProduct(new int[]{1,2,4,5,10}), 16)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Tuple with Same Product");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}