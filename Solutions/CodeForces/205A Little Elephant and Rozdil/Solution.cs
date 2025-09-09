// Little Elephant and Rozdil
namespace CompetitiveProgramming.CodeForces.LittleElephantandRozdil;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long[] array = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long currentMin = 1000000001, minPos = -1;
        for (long k = 0; k < n; k++)
        {
            if (array[k] < currentMin)
            {
                currentMin = array[k];
                minPos = k + 1;
            }
            else if (array[k] == currentMin)
            {
                minPos = -1;
            }
        }
        if (minPos == -1) Console.WriteLine("Still Rozdil");
        else Console.WriteLine(minPos);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Little Elephant and Rozdil");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}