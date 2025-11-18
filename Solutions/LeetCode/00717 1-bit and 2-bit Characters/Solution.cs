// 1-bit and 2-bit Characters
namespace CompetitiveProgramming.LeetCode.OnebitandTwobitCharacters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {
        int i = 0;
        int len = bits.Length;
        while (i < len - 1)
        {
            if (bits[i] == 1)
            {
                i++;
            }
            i++;
        }
        return i == len - 1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("1-bit and 2-bit Characters");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}