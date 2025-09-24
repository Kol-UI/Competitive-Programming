// DI String Match
namespace CompetitiveProgramming.LeetCode.DIStringMatch;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] DiStringMatch(string s)
    {
        int[] list = new int[s.Length+1];
        int left = 0;
        int right = s.Length;
        int i = 0;
        foreach(char c in s)
        {
            if(c=='I')
            {
                list[i++]=left++;
            }
            else
            {
                list[i++]=right--;
            }
        }
        list[s.Length]=left;
        return list;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("DI String Match");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}