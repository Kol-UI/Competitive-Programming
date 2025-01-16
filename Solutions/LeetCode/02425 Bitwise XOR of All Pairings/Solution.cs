// Bitwise XOR of All Pairings

namespace CompetitiveProgramming.LeetCode.BitwiseXORofAllPairings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int XorAllNums(int[] nums1, int[] nums2)
    {
        if (nums1.Length % 2 == 0)
        {
            if (nums2.Length % 2 == 0)
                return 0;
            else 
                return nums1.Aggregate((s, a) => s ^ a);
        }    

        if (nums2.Length % 2 == 0)
            return nums2.Aggregate((s, a) => s ^ a);

        return nums1.Concat(nums2).Aggregate((s, a) => s ^ a);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.XorAllNums(new int[]{2,1,3}, new int[]{10,2,5,0}), 13),
            ResultTester.CheckResult<int>(solution.XorAllNums(new int[]{1,2}, new int[]{3,4}), 0)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bitwise XOR of All Pairings");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}