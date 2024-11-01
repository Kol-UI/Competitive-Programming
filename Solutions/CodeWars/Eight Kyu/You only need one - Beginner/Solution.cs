// You only need one - Beginner

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.YouonlyneedoneBeginner
{
    public class Kata
    {
        public static bool CheckLinq(object[] a, object x)
        {
            return a.Contains(x);
        }

        public static bool Check(object[] a, object x)
        {
            foreach (var item in a)
            {
                if (item.Equals(x))
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Kata.Check(new object[] { 66, 101 }, 66), true),
                ResultTester.CheckResult<bool>(Kata.Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45), true),
                ResultTester.CheckResult<bool>(Kata.Check(new object[] { 't', 'e', 's', 't' }, 'e'), true),
                ResultTester.CheckResult<bool>(Kata.Check(new object[] { "what", "a", "great", "kata" }, "kat"), false),
                ResultTester.CheckResult<bool>(Kata.Check(new object[] { 1, "hello", 3.14, "world" }, "hello"), true),
                ResultTester.CheckResult<bool>(Kata.Check(new object[] { 1, "hello", 3.14, "world" }, 42), false),


                ResultTester.CheckResult<bool>(Kata.CheckLinq(new object[] { 66, 101 }, 66), true),
                ResultTester.CheckResult<bool>(Kata.CheckLinq(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45), true),
                ResultTester.CheckResult<bool>(Kata.CheckLinq(new object[] { 't', 'e', 's', 't' }, 'e'), true),
                ResultTester.CheckResult<bool>(Kata.CheckLinq(new object[] { "what", "a", "great", "kata" }, "kat"), false),
                ResultTester.CheckResult<bool>(Kata.CheckLinq(new object[] { 1, "hello", 3.14, "world" }, "hello"), true),
                ResultTester.CheckResult<bool>(Kata.CheckLinq(new object[] { 1, "hello", 3.14, "world" }, 42), false),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("You only need one - Beginner");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestCases());
        }
    }
}