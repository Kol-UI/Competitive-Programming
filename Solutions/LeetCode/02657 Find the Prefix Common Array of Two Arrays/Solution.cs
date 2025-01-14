// Find the Prefix Common Array of Two Arrays

namespace CompetitiveProgramming.LeetCode.FindthePrefixCommonArrayofTwoArrays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        HashSet<int> set = new HashSet<int>();
        int[] prefixCommon = new int[A.Length];
        int commonPref = 0;

        for(int i = 0; i < A.Length; i++)
        {
            if(!set.Add(A[i])) 
                commonPref++;

            if(!set.Add(B[i]))
                commonPref++;

            prefixCommon[i] = commonPref;
        }

        return prefixCommon;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int[]>(solution.FindThePrefixCommonArray(new int[]{1,3,2,4}, new int[]{3,1,2,4}), new int[]{0,2,3,4}),
            ResultTester.CheckResult<int[]>(solution.FindThePrefixCommonArray(new int[]{2,3,1}, new int[]{3,1,2}), new int[]{0,1,3}),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Prefix Common Array of Two Arrays");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}