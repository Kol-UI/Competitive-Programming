// Same Parity Summands
namespace CompetitiveProgramming.CodeForces.SameParitySummands;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            if (n < k)
            {
                Console.WriteLine("NO");
                continue;
            }

            bool nEven = n % 2 == 0;
            bool kEven = k % 2 == 0;

            if (nEven)
            {
                if (kEven || n >= 2 * k)
                {
                    Console.WriteLine("YES");
                    if (kEven)
                    {
                        for (int i = 0; i < k - 1; i++)
                            Console.Write("1 ");
                        Console.WriteLine(n - (k - 1));
                    }
                    else
                    {
                        for (int i = 0; i < k - 1; i++)
                            Console.Write("2 ");
                        Console.WriteLine(n - 2 * (k - 1));
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                if (!kEven)
                {
                    Console.WriteLine("YES");
                    for (int i = 0; i < k - 1; i++)
                        Console.Write("1 ");
                    Console.WriteLine(n - (k - 1));
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Same Parity Summands");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}