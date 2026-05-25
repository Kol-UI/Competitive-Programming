// Fair Candy Swap
namespace CompetitiveProgramming.LeetCode.FairCandySwap;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
    {

        int[] res = new int[2];
        int sumA = 0;
        int sumB = 0;
        HashSet<int> hsBob = new();

        foreach (int i in aliceSizes)
            sumA += i;

        foreach (int i in bobSizes)
        {
            sumB += i;
            hsBob.Add(i);
        }

        for (int i = 0; i < aliceSizes.Length; i++)
        {

            int valueToFindInBob = ((sumB - sumA) / 2) + aliceSizes[i];
            if (hsBob.Contains(valueToFindInBob))
            {
                res[0] = aliceSizes[i];
                res[1] = valueToFindInBob;

                return res;
            }
        }

        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.FairCandySwap([1,1], [2,2]), [1,2]),
            ResultTester.CheckResult<int[]>(solution.FairCandySwap([1,2], [2,3]), [1,2]),
            ResultTester.CheckResult<int[]>(solution.FairCandySwap([2], [1,3]), [2,3]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fair Candy Swap");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}