// Startup
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#nullable disable
namespace CompetitiveProgramming.CodeForces.Startup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine());
            
            for (int tc = 0; tc < t; ++tc)
            {
                int[] nk = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int n = nk[0];
                int k = nk[1];
                
                int[] b = new int[k];
                int[] c = new int[k];
                
                for (int i = 0; i < k; ++i)
                {
                    int[] temp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    b[i] = temp[0];
                    c[i] = temp[1];
                }
                
                Console.WriteLine(Solve(n, b, c));
            }
        }

        static int Solve(int n, int[] b, int[] c)
        {
            Dictionary<int, int> brandToCostSum = new Dictionary<int, int>();
            
            for (int i = 0; i < b.Length; ++i)
            {
                if (brandToCostSum.ContainsKey(b[i]))
                    brandToCostSum[b[i]] += c[i];
                else
                    brandToCostSum[b[i]] = c[i];
            }

            return brandToCostSum.Values
                .OrderByDescending(value => value)
                .Take(n)
                .Sum();
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Startup");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}
#nullable enable