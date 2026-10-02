// H-Index
namespace CompetitiveProgramming.LeetCode.HIndex;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int HIndex(int[] citations)
    {
        Array.Sort(citations);
        for(int i = 0;i < citations.Length; i++)
        {
            if(citations[i] >= citations.Length - i)
            {
                return citations.Length - i;
            }
        }
        return citations[citations.Length / 2];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.HIndex([3,0,6,1,5]), 3),
            ResultTester.CheckResult<int>(solution.HIndex([1,3,1]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("H-Index");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}