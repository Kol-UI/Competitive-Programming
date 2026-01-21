// Construct the Minimum Bitwise Array II
namespace CompetitiveProgramming.LeetCode.ConstructtheMinimumBitwiseArrayII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private int GetValue(int num)
    {
        int idx = 0;
        while ((1 << idx & num) != 0)
        {
            idx++;
        }

        if (idx == 0)
            return -1;

        return num - (int)Math.Pow(2, idx - 1);
    }

    public int[] MinBitwiseArray(IList<int> nums)
    {
        int len = nums.Count;
        List<int> result = new();
        foreach (int num in nums)
        {
            result.Add(GetValue(num));
        }

        return result.ToArray();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.MinBitwiseArray([2,3,5,7]), [-1,1,4,3]),
            ResultTester.CheckResult<int[]>(solution.MinBitwiseArray([11,13,31]), [9,12,15]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Construct the Minimum Bitwise Array II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}