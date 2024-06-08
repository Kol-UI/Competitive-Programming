using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.SquaringAnArgument
{
	public class Solution
	{
        // Write a static function "Square" here which takes a double
        // and returns the square of that double
        public static double Square(double num)
        {
            return Math.Pow(num, 2);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Squaring An Argument");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeWars, ProblemCategory.EightKyu);
        }
    }
}