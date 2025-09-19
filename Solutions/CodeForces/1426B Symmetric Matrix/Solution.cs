// Symmetric Matrix
namespace CompetitiveProgramming.CodeForces.SymmetricMatrix;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            bool symmetricExists = false;
            
            for (int i = 0; i < n; i++)
            {
                string[] tile1 = Console.ReadLine().Split();
                string[] tile2 = Console.ReadLine().Split();
                
                int a = int.Parse(tile1[0]);
                int b = int.Parse(tile1[1]);
                int c = int.Parse(tile2[0]);
                int d = int.Parse(tile2[1]);
                
                if (b == c)
                {
                    symmetricExists = true;
                }
            }
            
            if (m % 2 != 0)
            {
                Console.WriteLine("NO");
            }
            else if (symmetricExists)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
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
        StyleHelper.Title("Symmetric Matrix");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}