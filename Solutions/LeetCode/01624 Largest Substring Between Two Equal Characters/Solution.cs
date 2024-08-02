// Largest Substring Between Two Equal Characters


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LargestSubstringBetweenTwoEqualCharacters
{
    public class Solution
    {
        public static int MaxLengthBetweenEqualCharacters(string s)
        {
            Dictionary<char, int[]> leftAndRightOccurence = new Dictionary<char, int[]>();

            int i = 0;
            int maxLength = 0;
            foreach(char c in s)
            {
                if(leftAndRightOccurence.ContainsKey(c))
                {
                    leftAndRightOccurence[c][1] = i;
                    if (leftAndRightOccurence[c][1] - leftAndRightOccurence[c][0] > maxLength)
                    {
                        maxLength = leftAndRightOccurence[c][1] - leftAndRightOccurence[c][0];
                    }
                }
                else
                {
                    leftAndRightOccurence.Add(c, new int[2] { i, -1 });
                }
                i++;
            }

            return maxLength - 1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxLengthBetweenEqualCharacters("aa"), 0),
                ResultTester.CheckResult<int>(Solution.MaxLengthBetweenEqualCharacters("abca"), 2),
                ResultTester.CheckResult<int>(Solution.MaxLengthBetweenEqualCharacters("cbzxy"), -1),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1624");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}