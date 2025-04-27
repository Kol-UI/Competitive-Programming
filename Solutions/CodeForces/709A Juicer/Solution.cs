// Juicer
namespace CompetitiveProgramming.CodeForces.Juicer;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

public class Program
{
    //public static void Main()
    public static void MainSolution()
    {
        var inputs = Console.ReadLine()!.Split();
        int n = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        int d = int.Parse(inputs[2]);

        long sum = 0, cnt = 0;

        var oranges = Console.ReadLine()!.Split();
        for (int i = 0; i < n; i++)
        {
            int orange = int.Parse(oranges[i]);
            if (orange <= b)
                sum += orange;
            if (sum > d)
            {
                cnt++;
                sum = 0;
            }
        }

        Console.WriteLine(cnt);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Juicer");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}