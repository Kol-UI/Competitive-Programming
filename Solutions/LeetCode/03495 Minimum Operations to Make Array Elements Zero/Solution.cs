// Minimum Operations to Make Array Elements Zero
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoMakeArrayElementsZero;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MinOperations(int[][] queries)
    {
        long res = 0;

        foreach(var query in queries)
        {
            res += GetOperationsCount(query[0], query[1]);
        }

        return res;
    }

    private long GetOperationsCount(int start, int end)
    {
        long res = 0, i = 4, ops = 1;
        
        for(; i<=end; i = i*4, ops++)
        {
            if(start < i)
            {
                res = res + (i - start)*ops;
                start = (int)i;
            }
        }

        res = res + ((end + 1 - i/4) - (start - i/4))*ops;
        return (res+1)/2;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Make Array Elements Zero");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}