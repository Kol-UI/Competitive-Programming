// Towers
namespace CompetitiveProgramming.CodeForces.Towers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int N = int.Parse(Console.ReadLine());
        int[] length = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Array.Sort(length);
        
        int numTowers = 0, currentLength = 0, currentHeight = 1, maxHeight = 1;
        
        for (int k = 0; k < N; k++)
        {
            if (length[k] == currentLength)
            {
                currentHeight++;
                if (currentHeight > maxHeight) maxHeight = currentHeight;
            }
            else
            {
                currentLength = length[k];
                currentHeight = 1;
                numTowers++;
            }
        }
        
        Console.WriteLine($"{maxHeight} {numTowers}");
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
        StyleHelper.Title("Towers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}