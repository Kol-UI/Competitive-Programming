// Two Arrays
namespace CompetitiveProgramming.CodeForces.TwoArrays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            Array.Sort(a);
            Array.Sort(b);
            
            bool isValid = true;
            for (int i = 0; i < n; i++)
            {
                if (b[i] < a[i] || b[i] > a[i] + 1)
                {
                    isValid = false;
                    break;
                }
            }
            
            Console.WriteLine(isValid ? "YES" : "NO");
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
        StyleHelper.Title("Two Arrays");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}