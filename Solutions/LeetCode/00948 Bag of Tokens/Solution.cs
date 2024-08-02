// Bag of Tokens


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BagofTokens
{
    public class Solution
    {
        public static int BagOfTokensScore(int[] tokens, int power)
        {
            int n = tokens.Length;
            Array.Sort(tokens);
            int valueUp = 0;
            int valueDown = n - 1;
            int bag = 0;

            while(valueUp <= valueDown)
            {
                if(power >= tokens[valueUp])
                {
                    power -= tokens[valueUp++];
                    bag++;
                }
                else
                {
                    if(bag == 0 || valueUp == valueDown)
                        break;
                    power += tokens[valueDown--];
                    bag--;
                }
            }
            return bag;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.BagOfTokensScore(new int[]{100}, 50), 0),
                ResultTester.CheckResult<int>(Solution.BagOfTokensScore(new int[]{100,200,300,400}, 200), 2),
                ResultTester.CheckResult<int>(Solution.BagOfTokensScore(new int[]{200,100}, 150), 1),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Bag of Tokens");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}