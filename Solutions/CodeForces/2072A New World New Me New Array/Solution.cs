// New World, New Me, New Array
namespace CompetitiveProgramming.CodeForces.NewWorldNewMeNewArray;
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
            int p = int.Parse(input[2]);
            
            if (k < -n * p || k > n * p)
            {
                Console.WriteLine(-1);
            }
            else
            {
                int ans = Math.Abs(k);
                Console.WriteLine((ans / p) + (ans % p != 0 ? 1 : 0));
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
        StyleHelper.Title("New World, New Me, New Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}
