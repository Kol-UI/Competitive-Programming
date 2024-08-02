// Maximum Number of Words You Can Type


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofWordsYouCanType
{
    public class Solution
    {
        public static int CanBeTypedWords(string text, string brokenLetters)
        {
            if(string.IsNullOrEmpty(text))
            {
                return 0;
            }

            char[] broken = brokenLetters.ToCharArray();
            int count = 0;
            string[] word = text.Split(" ");

            for(int i = 0;i < word.Length; i++)
            {
                foreach(var j in broken)
                {
                    if(word[i].Contains(j))
                    {
                        count++;
                        break;
                    }
                }
            }
            return word.Length-count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CanBeTypedWords("hello world", "ad"), 1),
                ResultTester.CheckResult<int>(Solution.CanBeTypedWords("leet code", "lt"), 1),
                ResultTester.CheckResult<int>(Solution.CanBeTypedWords("leet code", "e"), 0),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1935");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}