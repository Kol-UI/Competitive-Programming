// Three Indices
namespace CompetitiveProgramming.CodeForces.ThreeIndices;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int idx = -1;
            for (int i = 1; i + 1 < n; i++)
            {
                if (v[i - 1] < v[i] && v[i] > v[i + 1])
                {
                    idx = i + 1;
                    break;
                }
            }
            if (idx != -1)
            {
                Console.WriteLine("YES");
                Console.WriteLine($"{idx - 1} {idx} {idx + 1}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Three Indices");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}