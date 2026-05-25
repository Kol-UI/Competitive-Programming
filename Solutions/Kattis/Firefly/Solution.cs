// Firefly
namespace CompetitiveProgramming.Kattis.Firefly;
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
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);
        
        int inf = 1 << 30;
        
        int[] suml = new int[m];
        int[] sumr = new int[m];
        
        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                sumr[t - 1]++;
            }
            else
            {
                suml[m - t]++;
            }
        }
        
        int sum = 0;
        for (int i = m - 1; i >= 0; i--)
        {
            sum += sumr[i];
            sumr[i] = sum;
        }
        
        sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum += suml[i];
            suml[i] = sum;
        }
        
        int best = inf;
        int count = 0;
        for (int i = 0; i < m; i++)
        {
            int total = suml[i] + sumr[i];
            if (total < best)
            {
                best = total;
                count = 0;
            }
            if (total == best)
            {
                count++;
            }
        }
        
        Console.WriteLine($"{best} {count}");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Firefly");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}