// Number of Unique XOR Triplets I
namespace CompetitiveProgramming.LeetCode.NumberofUniqueXORTripletsI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int UniqueXorTriplets(int[] nums)
    {
        if (nums.Length <= 2) return nums.Length;
        return (int)Math.Pow(2, (int)Math.Log2(nums.Length) + 1);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.UniqueXorTriplets([1,2]), 2),
            ResultTester.CheckResult<int>(solution.UniqueXorTriplets([3,1,2]), 4),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Unique XOR Triplets I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}