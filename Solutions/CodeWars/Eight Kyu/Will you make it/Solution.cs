// Will you make it
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeWars.EightKyu.Willyoumakeit
{
    public static class Kata
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            uint result = mpg * fuelLeft;
            return result >= distanceToPump;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Kata.ZeroFuel(50, 25, 2), true),
                ResultTester.CheckResult<bool>(Kata.ZeroFuel(100, 50, 1), false),
                ResultTester.CheckResult<bool>(Kata.ZeroFuel(60, 30, 3), true),
                ResultTester.CheckResult<bool>(Kata.ZeroFuel(70, 25, 1), false),
                ResultTester.CheckResult<bool>(Kata.ZeroFuel(100, 25, 3), false),
                ResultTester.CheckResult<bool>(Kata.ZeroFuel(70, 25, 1), false),
                ResultTester.CheckResult<bool>(Kata.ZeroFuel(70, 25, 1), false),
                ResultTester.CheckResult<bool>(Kata.ZeroFuel(70, 25, 1), false),
                ResultTester.CheckResult<bool>(Kata.ZeroFuel(70, 25, 1), false),
                ResultTester.CheckResult<bool>(Kata.ZeroFuel(70, 25, 1), false),
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("DNA to RNA Conversion");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestCases());
        }
    }
}