// Subtract Operation
namespace CompetitiveProgramming.CodeForces.SubtractOperation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            HashSet<int> mp = new HashSet<int>();
            
            foreach (int num in v)
            {
                mp.Add(num);
            }

            bool ok = false;
            foreach (int num in v)
            {
                if (mp.Contains(num - k))
                {
                    ok = true;
                    break;
                }
            }
            Console.WriteLine(ok ? "YES" : "NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Subtract Operation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}