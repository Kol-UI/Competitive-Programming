// Counting Orders
namespace CompetitiveProgramming.CodeForces.CountingOrders;
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
        const long MOD = 1000000007;
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            Array.Sort(a);
            Array.Sort(b);
            
            long index = n - 1;
            long result = 1;
            
            for (int p = n - 1; p >= 0; p--)
            {
                while (index >= 0 && a[index] > b[p]) index--;
                long diff = p - index;
                if (diff <= 0)
                {
                    result = 0;
                    break;
                }
                result = result * diff % MOD;
            }
            
            Console.WriteLine(result);
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
        StyleHelper.Title("Counting Orders");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}