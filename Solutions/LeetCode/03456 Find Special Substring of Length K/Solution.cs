// Find Special Substring of Length K
namespace CompetitiveProgramming.LeetCode.FindSpecialSubstringofLengthK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool HasSpecialSubstring(string s, int k)
    {
        int len = s.Length, index = 1, start = 0;
        if (len < k)
        {
            return false;
        }

        while (index < len)
        {
            char curr = s[index];
            if (curr != s[start])
            {
                if (index - start == k)
                {
                    return true;   
                }

                start = index;
            }

            index++;
        }

        return len - start == k;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Special Substring of Length K");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}