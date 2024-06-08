using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeWars.EightKyu.ReturnHelloWorld
{
	public class Solution
	{
        // Write a public static method "greet" that returns "hello world!"
        public static string greet()
        {
            return "hello world!";
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Return Hello World");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeWars, ProblemCategory.EightKyu);
        }
    }
}