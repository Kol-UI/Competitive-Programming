// Remove Zeros in Decimal Representation
namespace CompetitiveProgramming.LeetCode.RemoveZerosinDecimalRepresentation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long RemoveZeros(long n)
    {
        string res = string.Empty;
        string a = n.ToString();
        
        for(int i = 0;i < a.Length; i++)
        {
            if(a[i]-'0' > 0)
            {
                res += a[i];
            }
        }
        return long.Parse(res);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.RemoveZeros(1020030), 123),
            ResultTester.CheckResult<long>(solution.RemoveZeros(1), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Remove Zeros in Decimal Representation");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}