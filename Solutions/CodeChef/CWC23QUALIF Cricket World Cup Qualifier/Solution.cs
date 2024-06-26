// Cricket World Cup Qualifier


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.CricketWorldCupQualifier
{
    public class Test
    {
        //public static void Main()
        public static void Solution()
        {
            int X = int.Parse(Console.ReadLine()!);

            string result = (X >= 12) ? "Yes" : "No";

            Console.WriteLine(result);
        }

        public static string TestSolution(int X)
        {
            string result = (X >= 12) ? "Yes" : "No";
            return result;
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Test.TestSolution(3), "No"),
                ResultTester.CheckResult<string>(Test.TestSolution(17), "Yes"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Cricket World Cup Qualifier");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeChef, ProblemCategory.BeginnerCC, Test.TestCases());
        }
    }
}