// Odd or Even
using System.Linq;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.SevenKyu.OddorEven
{
    public class Kata
    {
        public static string OddOrEven(int[] array) => array.Sum() % 2 == 0 ? "even" : "odd";
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Kata.OddOrEven(new int[]{0}), "even"),
                ResultTester.CheckResult<string>(Kata.OddOrEven(new int[]{0, 1, 4}), "odd"),
                ResultTester.CheckResult<string>(Kata.OddOrEven(new int[]{0, -1, -5}), "even"),
                ResultTester.CheckResult<string>(Kata.OddOrEven(new int[]{1}), "odd"),
                ResultTester.CheckResult<string>(Kata.OddOrEven(Array.Empty<int>()), "even"),
                ResultTester.CheckResult<string>(Kata.OddOrEven(new int[]{0, 1, 5}), "even"),
                ResultTester.CheckResult<string>(Kata.OddOrEven(new int[]{0, 1, 3}), "even"),
                ResultTester.CheckResult<string>(Kata.OddOrEven(new int[]{1023, 1, 2}), "even"),
                ResultTester.CheckResult<string>(Kata.OddOrEven(new int[]{0, -1, -5}), "even"),
                ResultTester.CheckResult<string>(Kata.OddOrEven(new int[]{0, -1, -3}), "even"),
                ResultTester.CheckResult<string>(Kata.OddOrEven(new int[]{-1023, -1, -2}), "even"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Odd or Even");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.SevenKyu, Test.TestCases());
        }
    }
}