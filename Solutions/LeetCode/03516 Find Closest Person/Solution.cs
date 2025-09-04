// Find Closest Person
namespace CompetitiveProgramming.LeetCode.FindClosestPerson;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FindClosest(int x, int y, int z)
    {
        int a = Math.Abs(x - z); 
        int b = Math.Abs(y - z);
        if(a == b) return 0;
        return a > b ? 2 : 1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Closest Person");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}