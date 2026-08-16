// Stone Game IX
namespace CompetitiveProgramming.LeetCode.StoneGameIX;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public bool StoneGameIX(int[] stones)
    {
        int[] div = new int[3];
        foreach(int st in stones)
            div[st%3]++;

        bool pass = (div[0]%2==1);

        if(div[1]==0 && div[2]==0) return false;
        
        if(div[1]==0)
        {
            if(div[2]>2) return pass;
            else return false;
        }

        if(div[2]==0)
        {
            if(div[1]>2) return pass;
            else return false;
        }

        if(Math.Max(div[1],div[2]) > Math.Min(div[1], div[2]) + 2)
            return true;

        return (!pass);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Stone Game IX");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}
