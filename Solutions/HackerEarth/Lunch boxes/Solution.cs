// Lunch boxes

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
using System;
using System.Linq;

namespace CompetitiveProgramming.HackerEarth.Lunchboxes
{
    class Program
    {
        public static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < t; _++)
            {
                int[] nm = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                int n = nm[0], m = nm[1];

                int[] a = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(a);

                int count = 0;
                int sum = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] + sum <= n)
                    {
                        sum += a[i];
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lunch boxes");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}