// Lady Bug
namespace CompetitiveProgramming.CodeForces.LadyBug;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            
            int evenZerosA = 0;
            int evenZerosB = 0;
            int oddZerosA = 0;
            int oddZerosB = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    if (a[i] == '0') evenZerosA++;
                    if (b[i] == '0') evenZerosB++;
                }
                else
                {
                    if (a[i] == '0') oddZerosA++;
                    if (b[i] == '0') oddZerosB++;
                }
            }
            
            bool valid = (evenZerosA + oddZerosB >= (n + 1) / 2) && 
                        (oddZerosA + evenZerosB >= n / 2);
            
            Console.WriteLine(valid ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lady Bug");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}