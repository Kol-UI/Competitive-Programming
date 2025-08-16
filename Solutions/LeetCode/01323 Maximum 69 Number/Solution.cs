// Maximum 69 Number
namespace CompetitiveProgramming.LeetCode.MaximumSixtyNineNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int Maximum69Number(int num)
    {
        char[] chars = num.ToString().ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '6')
            {
                chars[i] = '9';
                break; 
            }
        }
        return int.Parse(new string(chars));
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum 69 Number");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}