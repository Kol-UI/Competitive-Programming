// Johnny and His Hobbies
namespace CompetitiveProgramming.CodeForces.JohnnyandHisHobbies;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        const int N = 1024;
        int t = int.Parse(Console.ReadLine());
        
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            HashSet<int> s = new HashSet<int>();
            
            for (int p = 0; p < n; p++)
            {
                s.Add(int.Parse(input[p]));
            }
            
            int res = -1;
            for (int u = 1; u < N; u++)
            {
                HashSet<int> w = new HashSet<int>();
                foreach (int val in s)
                {
                    w.Add(val ^ u);
                }
                
                if (s.SetEquals(w))
                {
                    res = u;
                    break;
                }
            }
            
            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Johnny and His Hobbies");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}