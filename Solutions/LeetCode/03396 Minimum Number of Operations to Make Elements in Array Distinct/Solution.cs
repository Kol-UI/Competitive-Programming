// Minimum Number of Operations to Make Elements in Array Distinct
namespace CompetitiveProgramming.LeetCode.MinimumNumberofOperationstoMakeElementsinArrayDistinct;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        int cnt = 0;
        var list = nums.ToList();        
        while(list.Count()>list.Distinct().Count())
        {
            list = list.Skip(3).ToList();
            cnt++;
        }
        return cnt;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Operations to Make Elements in Array Distinct");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}