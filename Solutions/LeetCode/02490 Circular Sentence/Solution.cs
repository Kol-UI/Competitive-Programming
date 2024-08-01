// Circular Sentence


using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CircularSentence
{
    public class Solution
    {
        public static bool IsCircularSentence(string sentence)
        {
            var words = sentence.Split(" ");
            if(words.Length < 1)
                return false;

            else if(!words[words.Length - 1].EndsWith(words[0][0]))
                return false;

            for(int i = 0; i < words.Length - 1; i++)
            {
                if(words[i+1][0] != (words[i][words[i].Length-1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsCircularSentence("leetcode exercises sound delightful"), true),
                ResultTester.CheckResult<bool>(Solution.IsCircularSentence("eetcode"), true),
                ResultTester.CheckResult<bool>(Solution.IsCircularSentence("Leetcode is cool"), false),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Circular Sentence");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}