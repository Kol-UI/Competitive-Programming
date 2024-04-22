// Greatest English Letter in Upper and Lower Case


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.GreatestEnglishLetterinUpperandLowerCase
{
    public class Solution
    {
        public static string GreatestLetter(string s)
        {
            char ch = '@';

            foreach (char c in s)
            {
                if (Char.IsUpper(c) && s.Contains(Char.ToLower(c)) && c > ch)
                    ch = c;
            }

            return ch == '@' ? "" : ch.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.GreatestLetter("lEeTcOdE"), "E"),
                ResultTester.CheckResult<string>(Solution.GreatestLetter("arRAzFif"), "R"),
                ResultTester.CheckResult<string>(Solution.GreatestLetter("AbCdEfGhIjK"), ""),
            };
            return results;
        }
    }
}