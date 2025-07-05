// Turtle Math: Fast Three Task
namespace CompetitiveProgramming.CodeForces.TurtleMathFastThreeTask;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += v[i];
            }
            if (sum % 3 == 0)
            {
                Console.WriteLine(0);
                continue;
            }
            if (sum % 3 == 2)
            {
                Console.WriteLine(1);
                continue;
            }
            int ans = 2;
            for (int i = 0; i < n; i++)
            {
                sum -= v[i];
                if (sum % 3 == 0)
                {
                    ans = 1;
                    break;
                }
                sum += v[i];
            }
            Console.WriteLine(ans);
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
        StyleHelper.Title("Turtle Math: Fast Three Task");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}