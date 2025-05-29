// Scuza
namespace CompetitiveProgramming.CodeForces.Scuza;
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
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            var firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]);
            int q = int.Parse(firstLine[1]);
            
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] k = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long[] prefixSum = new long[n + 1];
            long[] prefixMax = new long[n + 1];
            
            for (int i = 0; i < n; i++)
            {
                prefixSum[i + 1] = prefixSum[i] + a[i];
                prefixMax[i + 1] = Math.Max(prefixMax[i], a[i]);
            }
            
            var results = new long[q];
            for (int i = 0; i < q; i++)
            {
                int left = 0;
                int right = n;
                while (left < right)
                {
                    int mid = (left + right + 1) / 2;
                    if (prefixMax[mid] <= k[i])
                        left = mid;
                    else
                        right = mid - 1;
                }
                results[i] = prefixSum[left];
            }
            
            Console.WriteLine(string.Join(" ", results));
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
        StyleHelper.Title("Scuza");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}