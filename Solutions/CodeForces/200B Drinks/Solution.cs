// Drinks

using System;
using System.Linq;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.Drinks;

class Program
{
    //static void Main()
    static void Solution()
    {
        int n = int.Parse(Console.ReadLine()!);
        double[] fractions = Console.ReadLine()!.Split().Select(double.Parse).ToArray();
        double average = fractions.Sum() / n;
        Console.WriteLine(average);
    }
}

public class Test
{
    public static double CalculateAverageFraction(int numberOfDrinks, double[] fractions)
    {
        if (fractions.Length == 0)
        {
            return 0;
        }
        double average = fractions.Sum() / numberOfDrinks;
        return average;
    }

    public static bool[] TestCases()
    {
        int case1_A = 3;
        double[] case1_B = {0.5, 0.2, 0.8};
        int case2_A = 5;
        double[] case2_B = {0.1, 0.2, 0.3, 0.4, 0.5};
        int case3_A = 1;
        double[] case3_B = {0.9};

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<double>(Test.CalculateAverageFraction(case1_A, case1_B), 0.5),
            ResultTester.CheckResult<double>(Test.CalculateAverageFraction(case2_A, case2_B), 0.3),
            ResultTester.CheckResult<double>(Test.CalculateAverageFraction(case3_A, case3_B), 0.9),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Drinks");
        ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
    }
}