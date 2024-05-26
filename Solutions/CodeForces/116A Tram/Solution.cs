// 116A Tram

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.Tram;
class Program
{
    // static void Main()
    static void Solution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int maxCapacity = 0;
        int currentCapacity = 0;

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()!.Split();
            int exiting = int.Parse(input[0]);
            int entering = int.Parse(input[1]);

            currentCapacity = currentCapacity - exiting + entering;
            maxCapacity = Math.Max(maxCapacity, currentCapacity);
        }

        Console.WriteLine(maxCapacity);
    }
}

class Test
{
    public static int CalculateMinTramCapacity(int n, int[] exitingPassengers, int[] enteringPassengers)
    {
        int maxCapacity = 0;
        int currentCapacity = 0;

        for (int i = 0; i < n; i++)
        {
            currentCapacity = currentCapacity - exitingPassengers[i] + enteringPassengers[i];
            maxCapacity = Math.Max(maxCapacity, currentCapacity);
        }

        return maxCapacity;
    }

    public static bool[] TestCases()
    {
        int n = 3;
        int[] exiting = { 0, 2, 1 };
        int[] entering = { 1, 3, 0 };

        int n2 = 4;
        int[] exiting2 = { 0, 0, 0, 0 };
        int[] entering2 = { 1, 2, 3, 4 };

        int n3 = 5;
        int[] exiting3 = { 0, 1, 1, 1, 1 };
        int[] entering3 = { 1, 1, 1, 1, 0 };

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(Test.CalculateMinTramCapacity(n, exiting, entering), 2),
            ResultTester.CheckResult<int>(Test.CalculateMinTramCapacity(n2, exiting2, entering2), 10),
            ResultTester.CheckResult<int>(Test.CalculateMinTramCapacity(n3, exiting3, entering3), 1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Tram");
        ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
    }
}