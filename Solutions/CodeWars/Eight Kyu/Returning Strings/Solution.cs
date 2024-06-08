// Returning Strings

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeWars.EightKyu.ReturningStrings
{
    public static class Solution
    {
        public static string Greet(string name)
        {
            return "Hello, " + name + " how are you doing today?";
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Returning Strings");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeWars, ProblemCategory.EightKyu);
        }
    }
}