// Eating Candies
namespace CompetitiveProgramming.CodeForces.EatingCandies;
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
            int n = int.Parse(Console.ReadLine()!);
            int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int i = -1, j = n;
            int ans = 0, cnt = 0;
            long sa = 0, sb = 0;

            while (i < j)
            {
                if (sa == sb)
                {
                    ans += cnt;
                    if (i + 1 < n)
                    {
                        sa = arr[i + 1];
                        cnt = 1;
                        i++;
                        sb = 0;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (sa < sb)
                {
                    if (i + 1 < n)
                    {
                        sa += arr[i + 1];
                        i++;
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (j - 1 >= 0)
                    {
                        sb += arr[j - 1];
                        j--;
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Eating Candies");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}