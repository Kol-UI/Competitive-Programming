// Keyboard Row


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KeyboardRow
{
    public class Solution
    {
        public static string[] FindWords(string[] words)
        {
            char[] first = {'e', 'i', 'o', 'p', 'q', 'r', 't', 'u', 'w', 'y' };
            char[] second = {'a', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 's'};
            char[] third = {'b', 'c', 'm', 'n', 'v', 'x', 'z'};

            List<string> result = new();
            foreach (string word in words)
            {
                HashSet<char> tempo = new(word.ToLower().ToCharArray());
                if (tempo.IsSubsetOf(first) || tempo.IsSubsetOf(second) || tempo.IsSubsetOf(third))
                {
                    result.Add(word);
                }
            }
            return result.ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string[]>(Solution.FindWords(new string[]{"Hello","Alaska","Dad","Peace"}), new string[]{"Alaska","Dad"}),
                ResultTester.CheckResult<string[]>(Solution.FindWords(new string[]{"omk"}), new string[]{}),
                ResultTester.CheckResult<string[]>(Solution.FindWords(new string[]{"adsdf","sfd"}), new string[]{"adsdf","sfd"}),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("500");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}