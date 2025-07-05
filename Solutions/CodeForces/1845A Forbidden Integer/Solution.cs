// Forbidden Integer
namespace CompetitiveProgramming.CodeForces.ForbiddenInteger;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int x = int.Parse(input[2]);
            
            if (x != 1)
            {
                Console.WriteLine("YES");
                Console.WriteLine(n);
                for (int i = 0; i < n; i++)
                {
                    Console.Write(1);
                    if (i == n - 1) Console.WriteLine();
                    else Console.Write(" ");
                }
            }
            else
            {
                if (k >= 2 && n % 2 == 0)
                {
                    Console.WriteLine("YES");
                    Console.WriteLine(n / 2);
                    for (int i = 0; i < n / 2; i++)
                    {
                        Console.Write(2);
                        if (i != n / 2 - 1) Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                else if (k >= 3)
                {
                    Console.WriteLine("YES");
                    Console.WriteLine(n / 2);
                    for (int i = 0; i < n / 2 - 1; i++)
                    {
                        Console.Write(2 + " ");
                    }
                    Console.WriteLine(3);
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Forbidden Integer");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}