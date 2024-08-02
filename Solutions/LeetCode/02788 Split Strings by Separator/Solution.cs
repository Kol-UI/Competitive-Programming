// Split Strings by Separator


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SplitStringsbySeparator
{
    public class Solution
    {
        public static IList<string> SplitWordsBySeparator(IList<string> words, char separator)
        {
            IList<string> result = new List<string>();

            foreach(var items in words)
            {
                foreach(var item in items.Split(separator))
                {
                    if(!String.IsNullOrEmpty(item))
                    {
                        result.Add(item);
                    }
                }
            }
            
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            IList<string> words1 = new List<string> { "one.two.three", "four.five", "six" };
            char separator1 = '.';
            IList<string> expected1 = new List<string> { "one", "two", "three", "four", "five", "six" };

            IList<string> words2 = new List<string> { "$easy$", "$problem$" };
            char separator2 = '$';
            IList<string> expected2 = new List<string> { "easy", "problem" };

            IList<string> words3 = new List<string> { "|||" };
            char separator3 = '|';
            IList<string> expected3 = new List<string> { };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<string>>(Solution.SplitWordsBySeparator(words1, separator1), expected1),
                ResultTester.CheckResult<IList<string>>(Solution.SplitWordsBySeparator(words2, separator2), expected2),
                ResultTester.CheckResult<IList<string>>(Solution.SplitWordsBySeparator(words3, separator3), expected3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2788");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}