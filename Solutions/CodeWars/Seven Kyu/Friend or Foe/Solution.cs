// Friend or Foe

using System.Linq;
using System.Text.RegularExpressions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.SevenKyu.FriendorFoe
{
    public static class Kata 
    {
        public static IEnumerable<string> FriendOrFoe (string[] names) => names.Where(name => name.Length == 4);
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            IEnumerable<string> names = new string[] { "Ryan", "Mark" };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IEnumerable<string>>(Kata.FriendOrFoe(new string[]{"Ryan", "Kieran", "Mark"}), names),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Friend or Foe");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.SevenKyu, Test.TestCases());
        }
    }
}