// Replace and Sum
namespace CompetitiveProgramming.CodeForces.ReplaceandSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class HelloWorld
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int q = input[1];
            
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] b = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            a[n - 1] = Math.Max(a[n - 1], b[n - 1]);
            for(int p = n - 1; p >= 0; p--)
            {
                a[p] = Math.Max(a[p], b[p]);
                if(p + 1 < n && a[p] < a[p + 1])
                {
                    a[p] = a[p + 1];
                }
            }
            
            for(int p = 1; p < n; p++)
            {
                a[p] += a[p - 1];
            }
            
            for(int j = 0; j < q; j++)
            {
                var query = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int left = query[0] - 1;
                int right = query[1] - 1;
                
                long result = a[right] - (left > 0 ? a[left - 1] : 0);
                Console.Write($"{result} ");
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
        StyleHelper.Title("Replace and Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}