// Convert a string to an array
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeWars.EightKyu.Convertastringtoanarray
{
    public class Solution
    {
        public static string[] StringToArray(string str)
        {
            return str.Split(' ');
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string[]>(Solution.StringToArray("Robin Singh"), new string[] {"Robin", "Singh"}),
                ResultTester.CheckResult<string[]>(Solution.StringToArray("I love arrays they are my favorite"), new string[] {"I", "love", "arrays", "they", "are", "my", "favorite"}),
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert a string to an array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestCases());
        }
    }
}