// Disemvowel Trolls

using System.Text.RegularExpressions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.SevenKyu.DisemvowelTrolls
{
    public static class Kata
    {
        public static string Disemvowel(string str) => Regex.Replace(str, "[aeuoi]", string.Empty, RegexOptions.IgnoreCase);
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Kata.Disemvowel("This website is for losers LOL!"), "Ths wbst s fr lsrs LL!"),
                ResultTester.CheckResult<string>(Kata.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"), "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd"),
                ResultTester.CheckResult<string>(Kata.Disemvowel("What are you, a communist?"), "Wht r y,  cmmnst?"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Disemvowel Trolls");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.SevenKyu, Test.TestCases());
        }
    }
}