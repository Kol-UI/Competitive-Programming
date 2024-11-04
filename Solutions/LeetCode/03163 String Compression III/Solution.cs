// String Compression III

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.StringCompressionIII
{
    public class Solution
    {
        public string CompressedString(string word)
        {
            StringBuilder comp = new StringBuilder();
            int count = 1;
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] != word[i - 1])
                {
                    comp.Append($"{count}{word[i - 1]}");
                    count = 1;
                }
                else
                {
                    if(count < 9)
                    {
                        count++;
                    }
                    else
                    {
                        comp.Append($"9{word[i - 1]}");
                        count = 1;
                    }
                }
            }
            comp.Append($"{count}{word[word.Length - 1]}");
            return comp.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(solution.CompressedString("abcde"), "1a1b1c1d1e"),
                ResultTester.CheckResult<string>(solution.CompressedString("aaaaaaaaaaaaaabb"), "9a5a2b")
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Compression III");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}