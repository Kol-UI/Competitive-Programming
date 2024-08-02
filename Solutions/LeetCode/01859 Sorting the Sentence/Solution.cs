// Sorting the Sentence


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SortingtheSentence
{
    public class Solution
    {
        public static string SortSentence(string s) => s
            .Split()
            .OrderBy(w => w[^1])
            .Select(w => w[..^1])
            .Aggregate((a, w) => a + " " + w);
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.SortSentence("is2 sentence4 This1 a3"), "This is a sentence"),
                ResultTester.CheckResult<string>(Solution.SortSentence("Myself2 Me1 I4 and3"), "Me Myself and I"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sorting the Sentence");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}