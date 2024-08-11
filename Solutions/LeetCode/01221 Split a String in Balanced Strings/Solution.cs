// Split a String in Balanced Strings

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SplitaStringinBalancedStrings
{
    public class Solution 
    {
        public int BalancedStringSplit(string s) 
        {
            int balancedCount = 0;
            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R') 
                {
                    rightCount++;
                }
                else 
                {
                    leftCount++;
                }

                if (leftCount == rightCount) 
                {
                    balancedCount++;
                }
            }

            return balancedCount;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Split a String in Balanced Strings");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}