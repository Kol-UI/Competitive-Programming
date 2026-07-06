// Decode XORed Array
namespace CompetitiveProgramming.LeetCode.DecodeXORedArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] Decode(int[] encoded, int first)
    {
        int[] res = new int[encoded.Length + 1];
        res[0] = first;
        for(int i = 1; i <= encoded.Length; i++)
        {
            res[i] = encoded[i-1] ^ res[i-1];
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
            ResultTester.CheckResult<int[]>(solution.Decode([1,2,3], 1), [1,0,2,1]),
            ResultTester.CheckResult<int[]>(solution.Decode([6,2,7,3], 4), [4,2,0,7,4]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Decode XORed Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}