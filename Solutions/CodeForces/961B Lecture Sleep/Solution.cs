// Lecture Sleep
namespace CompetitiveProgramming.CodeForces.LectureSleep;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string[] input = Console.ReadLine()!.Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);

        int[] a = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int[] b = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        int sum = 0;
        int mx = 0;
        int j = 0;

        for (int i = 0; i < n; i++)
        {
            if (i >= k)
            {
                while (j <= i - k)
                {
                    if (b[j] == 0)
                    {
                        sum -= a[j];
                    }
                    j++;
                }
            }

            if (b[i] == 0)
            {
                sum += a[i];
            }

            mx = Math.Max(sum, mx);
        }

        for (int i = 0; i < n; i++)
        {
            if (b[i] == 1)
            {
                mx += a[i];
            }
        }

        Console.WriteLine(mx);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lecture Sleep");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}