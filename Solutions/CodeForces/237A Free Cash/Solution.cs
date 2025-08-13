// Free Cash
namespace CompetitiveProgramming.CodeForces.FreeCash;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int numClients = int.Parse(Console.ReadLine());
        int concurrent = 1, needed = 1;
        int hour = -1, min = -1;

        while (numClients-- > 0)
        {
            int[] time = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = time[0], b = time[1];

            if (a == hour && b == min)
            {
                concurrent++;
                needed = Math.Max(needed, concurrent);
            }
            else
            {
                hour = a;
                min = b;
                concurrent = 1;
            }
        }

        Console.WriteLine(needed);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Free Cash");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}