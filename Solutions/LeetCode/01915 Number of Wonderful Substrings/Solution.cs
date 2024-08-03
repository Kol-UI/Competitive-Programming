// Number of Wonderful Substrings

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofWonderfulSubstrings
{
    public class Solution
    {
        public static long WonderfulSubstrings(string word)
        {
            var previousValue = new long[1024];
            var currentValue = new long[1024];
            var result = 0L;

            for (var i = 0; i < word.Length; ++i)
            {
                Array.Fill(currentValue, 0);

                for (var j = 0; j < 1024; ++j)
                {
                    currentValue[j ^ (1 << (word[i] - 'a'))] = previousValue[j];
                }

                ++currentValue[1 << (word[i] - 'a')];

                result += currentValue[0];

                for (var j = 0; j < 10; ++j)
                {
                    result += currentValue[1 << j];
                }

                (currentValue, previousValue) = (previousValue, currentValue);
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Solution.WonderfulSubstrings("aabb"), 9),
                ResultTester.CheckResult<long>(Solution.WonderfulSubstrings("aba"), 4),
                ResultTester.CheckResult<long>(Solution.WonderfulSubstrings("he"), 2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Number of Wonderful Substrings");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}