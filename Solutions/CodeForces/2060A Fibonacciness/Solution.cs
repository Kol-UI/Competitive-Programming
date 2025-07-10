// Fibonacciness
namespace CompetitiveProgramming.CodeForces.Fibonacciness;
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
            int a1 = int.Parse(input[0]);
            int a2 = int.Parse(input[1]);
            int a4 = int.Parse(input[2]);
            int a5 = int.Parse(input[3]);
            
            int maxFibonacciness = 0;
            
            int[] candidates = {
                a1 + a2,
                (a4 - a2),
                (a5 - a4),
                0
            };
            
            foreach (int a3 in candidates)
            {
                int current = 0;
                if (a3 == a1 + a2) current++;
                if (a4 == a2 + a3) current++;
                if (a5 == a3 + a4) current++;
                
                if (current > maxFibonacciness)
                {
                    maxFibonacciness = current;
                }
            }
            
            Console.WriteLine(maxFibonacciness);
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
        StyleHelper.Title("Fibonacciness");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}
