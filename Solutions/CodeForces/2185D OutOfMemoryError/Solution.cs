// OutOfMemoryError
namespace CompetitiveProgramming.CodeForces.OutOfMemoryError;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            int h = input[2];
            
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int[] v = new int[n];
            int[] w = new int[n];
            for(int p = 0; p < n; p++) w[p] = -1;
            
            int reset = 0;
            
            for(int p = 1; p <= m; p++)
            {
                var query = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int b = query[0] - 1;
                int c = query[1];
                
                if(reset >= w[b]) v[b] = a[b];
                w[b] = p;
                v[b] += c;
                
                if(v[b] > h)
                {
                    v[b] = a[b];
                    reset = p;
                }
            }
            
            for(int p = 0; p < n; p++)
            {
                long value = w[p] > reset ? v[p] : a[p];
                Console.Write($"{value} ");
            }
            Console.WriteLine();
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
        StyleHelper.Title("OutOfMemoryError");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}