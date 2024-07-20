// Maximum Number of Words Found in Sentences

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofWordsFoundinSentences
{
    public class Solution
    {
        public static int MostWordsFound(string[] sentences)
        {
            int maxWords = 0;
            foreach(var sentence in sentences)
            {
                maxWords = Math.Max(maxWords, sentence.Split(' ').Count());
            }
            return maxWords;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MostWordsFound(new string[]{"alice and bob love leetcode", "i think so too", "this is great thanks very much"}), 6),
                ResultTester.CheckResult<int>(Solution.MostWordsFound(new string[]{"please wait", "continue to fight", "continue to win"}), 3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Words Found in Sentences");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}