// Check if Strings Can be Made Equal With Operations II
namespace CompetitiveProgramming.LeetCode.CheckifStringsCanbeMadeEqualWithOperationsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckStrings(string s1, string s2)
    {
        int len = s1.Length;
        if (s1 == s2)
            return true;

        int[,] sample = new int[26, 2];
        for (int i = 0; i < len; i++)
        {
            int c1 = s1[i] - 'a', c2 = s2[i] - 'a';

            int j = i % 2;
            sample[c1, j]++;
            sample[c2, j]--;
        }

        for (int i = 0; i < 26; i++)
        {
            if (sample[i, 0] != 0 || sample[i, 1] != 0)
                return false;
        }

        return true;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Strings Can be Made Equal With Operations II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}