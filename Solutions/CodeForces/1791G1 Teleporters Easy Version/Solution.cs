// Teleporters (Easy Version)
namespace CompetitiveProgramming.CodeForces.TeleportersEasyVersion;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], b = input[1];
            int[] v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            
            for (int p = 0; p < n; p++)
                v[p] += p + 1;
            
            Array.Sort(v);
            int cnt = 0;
            
            for (int p = 0; p < n; p++)
            {
                if (v[p] <= b)
                {
                    b -= v[p];
                    cnt++;
                }
                else
                    break;
            }
            
            Console.WriteLine(cnt);
        }
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
        StyleHelper.Title("Teleporters (Easy Version)");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}