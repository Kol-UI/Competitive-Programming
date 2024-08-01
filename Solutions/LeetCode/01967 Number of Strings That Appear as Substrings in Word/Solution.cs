// Number of Strings That Appear as Substrings in Word

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofStringsThatAppearasSubstringsinWord
{
    public class Solution
    {
        public static int NumOfStrings(string[] patterns, string word)
        {
            int count = 0;
            foreach(string item in patterns)
            {
                if(word.Contains(item))
                {
                    count++;
                }
            }
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumOfStrings(new string[]{"a","abc","bc","d"}, "abc"), 3),
                ResultTester.CheckResult<int>(Solution.NumOfStrings(new string[]{"a","b","c"}, "aaaaabbbbb"), 2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Strings That Appear as Substrings in Word");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}