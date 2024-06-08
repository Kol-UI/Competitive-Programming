// String ends with

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.SevenKyu.Stringendswith
{
    public class Kata
    {
        public static bool Solution(string str, string ending)
        {
            return str.EndsWith(ending);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Kata.Solution("samurai", "ai"), true),
                ResultTester.CheckResult<bool>(Kata.Solution("sumo", "omo"), false),
                ResultTester.CheckResult<bool>(Kata.Solution("ninja", "ja"), true),
                ResultTester.CheckResult<bool>(Kata.Solution("sensei", "i"), true),
                ResultTester.CheckResult<bool>(Kata.Solution("samurai", "ra"), false),
                ResultTester.CheckResult<bool>(Kata.Solution("abc", "abcd"), false),
                ResultTester.CheckResult<bool>(Kata.Solution("abc", "abc"), true),
                ResultTester.CheckResult<bool>(Kata.Solution("abcabc", "bc"), true),
                ResultTester.CheckResult<bool>(Kata.Solution("ails", "fails"), false),
                ResultTester.CheckResult<bool>(Kata.Solution("fails", "ails"), true),
                ResultTester.CheckResult<bool>(Kata.Solution("this", "fails"), false),
                ResultTester.CheckResult<bool>(Kata.Solution("abc", ""), true),
                ResultTester.CheckResult<bool>(Kata.Solution(":-)", ":-("), false),
                ResultTester.CheckResult<bool>(Kata.Solution("!@#$%^&*() :-)", ":-)"), true),
                ResultTester.CheckResult<bool>(Kata.Solution("abc\n", "abc"), false),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("String ends with");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.SevenKyu, Test.TestCases());
        }
    }
}