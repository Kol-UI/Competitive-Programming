// Odd String Difference


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.OddStringDifference
{
    public class Solution
    {
        public static string OddString(string[] words)
        {
            var differenceCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var difference = getDifference(word);
                differenceCounts[difference] = differenceCounts.GetValueOrDefault(difference) + 1;
            }

            foreach (var word in words)
            {
                if (differenceCounts[getDifference(word)] == 1)
                {
                    return word;
                }
            }

            return string.Empty;
        }

        private static string getDifference(string word)
        {
            var difference = new StringBuilder();
            for (var i = 0; i < word.Length - 1; i++)
            {
                difference.Append(word[i + 1] - word[i]);
                difference.Append(",");
            }

            return difference.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.OddString(new string[]{"adc","wzy","abc"}), "abc"),
                ResultTester.CheckResult<string>(Solution.OddString(new string[]{"aaa","bob","ccc","ddd"}), "bob"),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Odd String Difference");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}